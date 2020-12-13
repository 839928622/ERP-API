using ERP_API.HubConfiguration;
using ERP_API.Models;
using ERP_API.Service.PrincipalAccessor;
using IdentityServer4.AccessTokenValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using ERP_API.Infrastructure;
using ERP_API.Service.BranchSettings;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Moq;

namespace ERP_API
{
    public class StartupDevelopment
    {
        public StartupDevelopment(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddHttpContextAccessor();
            services.AddDbContext<ApplicationDbContext>((serviceProvider, options) =>
            {
                var httpContext = serviceProvider.GetService<IHttpContextAccessor>().HttpContext;
                var httpRequest = httpContext.Request;
                var connection = GetConnection(httpRequest);
                options.UseSqlServer(connection);
            });
            services.AddMemoryCache();//使用缓存 测试环境，暂时不用数据库
            services.AddSingleton<IPrincipalAccessor, PrincipalAccessor>();
            services.AddDistributedMemoryCache();
            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear(); //我们关闭了jwt claims的类型映射，以便允许well-known claims的接入
            //services.AddAuthentication("Bearer")
            //        .AddJwtBearer("Bearer", options =>
            //        {
            //            options.Authority = "http://localhost:6556"; //授权服务器端点
            //            options.RequireHttpsMetadata = false;//不需要https，生产环境根据需要适配
            //            options.Audience = "ERP-API";//需要在授权服务器登记该信息，位于ApiResource表,ApiScopes表示api可以访问哪些资源
            //            options.TokenValidationParameters.ClockSkew = TimeSpan.FromMinutes(60);//每隔60分钟本API项目验证一次token
            //            options.TokenValidationParameters.RequireExpirationTime = true;//要求token必须设置过期时间

            //        });
            //IdentityServerAuthenticationDefaults.AuthenticationScheme里面的值就是Bearer 和上面的纯手写的一样
            //IdentityServerAuthenticationDefaults.AuthenticationScheme
            services.AddAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme)
                .AddIdentityServerAuthentication(options =>
                {
                    options.Authority = "http://localhost:6566";
                    options.ApiName = "ERP-API";
                    options.ApiSecret = "ERP-API secret";
                    options.RequireHttpsMetadata = false;//测试环境下 不适用https
                    options.SupportedTokens = SupportedTokens.Reference;
                    options.EnableCaching = true;
                    options.CacheDuration = TimeSpan.FromSeconds(300);

                });
            services.AddAuthorization();

            //services.AddAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme)
            //       .AddIdentityServerAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme,
            //           jwtOptions =>
            //       {
            //           // base-address of your identityserver
            //           //jwtOptions.Authority = "http://localhost:6566";

            //       }, referenceOptions =>
            //        {
            //               referenceOptions.Authority = "http://localhost:6566";
            //               referenceOptions.ClientId = "ERP-API";
            //               referenceOptions.ClientSecret = "secret";

            //               referenceOptions.EnableCaching = true;
            //               referenceOptions.CacheDuration = TimeSpan.Zero;
            //        });

            services.AddCors(options =>
            {
                options.AddPolicy("ERP-Angular-WebApp", builder =>
                    {
                        builder.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin();
                    });

            });

            services.AddHttpContextAccessor();
            services.AddSignalR();
            services.AddTransient<IBranchSettingService, BranchSettingService>();
        }

        private string GetConnection(HttpRequest httpRequest)
        {
            var clientClaim = httpRequest.HttpContext?.User.Claims
                .Where(c => c.Type == CustomizedClaims.BranchId)
                .Select(c => c.Value).SingleOrDefault();
            return clientClaim == null ? Configuration.GetConnectionString("DefaultConnection") 
                                       : Configuration.GetConnectionString(clientClaim);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //MultitenancyMigrateOperator.Migrate();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors("ERP-Angular-WebApp");

            //app.UseHttpsRedirection(); 测试环境，就不用https

            app.UseRouting();
            app.UseAuthentication();//解决你是谁的问题
            app.UseAuthorization();//解决 你可以干什么的问题

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHub<AdvancedSettingHub>("/AdvancedSetting");
            });
        }

    }
    public class StartupProduction
    {
        public StartupProduction(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddAuthentication("Bearer")
                .AddJwtBearer("Bearer", options =>
                {
                    options.Authority = "http://localhost:6556"; //授权服务器端点
                    options.RequireHttpsMetadata = false;//不需要https，生产环境根据需要适配
                    options.Audience = "ERP-API";//
                    options.TokenValidationParameters.ClockSkew = TimeSpan.Zero;
                    options.TokenValidationParameters.RequireExpirationTime = true;

                });
            services.AddHttpContextAccessor();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();//生产环境 可以根据需要把http请求强制转为https请求

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHub<AdvancedSettingHub>("/AdvancedSetting");
            });
        }
    }

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddHttpContextAccessor();
            //services.AddAuthentication("Bearer")
            //    .AddJwtBearer("Bearer", options =>
            //    {
            //        options.Authority = "http://localhost:6556"; //授权服务器端点
            //        options.RequireHttpsMetadata = false;//不需要https，生产环境根据需要适配
            //        options.Audience = "ERP-API";//需要在授权服务器登记该信息，位于ApiScopes表

            //    });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
