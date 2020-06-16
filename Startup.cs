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
using System.Security.Claims;
using ERP_API.Infrastructure;
using ERP_API.Service.BrandSettings;
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
            services.AddDbContext<ApplicationDbContext>(options => { });//���������������
            services.AddMemoryCache();//ʹ�û��� ���Ի�������ʱ�������ݿ�
            services.AddHttpContextAccessor();
            services.AddSingleton<IPrincipalAccessor, PrincipalAccessor>();
            services.AddDistributedMemoryCache();
            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear(); //���ǹر���jwt claims������ӳ�䣬�Ա�����well-known claims�Ľ���
            //services.AddAuthentication("Bearer")
            //        .AddJwtBearer("Bearer", options =>
            //        {
            //            options.Authority = "http://localhost:6556"; //��Ȩ�������˵�
            //            options.RequireHttpsMetadata = false;//����Ҫhttps����������������Ҫ����
            //            options.Audience = "ERP-API";//��Ҫ����Ȩ�������ǼǸ���Ϣ��λ��ApiResource��,ApiScopes��ʾapi���Է�����Щ��Դ
            //            options.TokenValidationParameters.ClockSkew = TimeSpan.FromMinutes(60);//ÿ��60���ӱ�API��Ŀ��֤һ��token
            //            options.TokenValidationParameters.RequireExpirationTime = true;//Ҫ��token�������ù���ʱ��

            //        });
            //IdentityServerAuthenticationDefaults.AuthenticationScheme�����ֵ����Bearer ������Ĵ���д��һ��
            //IdentityServerAuthenticationDefaults.AuthenticationScheme
            services.AddAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme)
                .AddIdentityServerAuthentication(options =>
                {
                    options.Authority = "http://localhost:6566";
                    options.ApiName = "ERP-API";
                    options.ApiSecret = "ERP-API secret";
                    options.RequireHttpsMetadata = false;//���Ի����� ������https
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

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            MultitenancyMigrator.Migrate();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors("ERP-Angular-WebApp");

            //app.UseHttpsRedirection(); ���Ի������Ͳ���https

            app.UseRouting();
            app.UseAuthentication();//�������˭������
            app.UseAuthorization();//��� ����Ը�ʲô������
            
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
                    options.Authority = "http://localhost:6556"; //��Ȩ�������˵�
                    options.RequireHttpsMetadata = false;//����Ҫhttps����������������Ҫ����
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

            app.UseHttpsRedirection();//�������� ���Ը�����Ҫ��http����ǿ��תΪhttps����

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
            //        options.Authority = "http://localhost:6556"; //��Ȩ�������˵�
            //        options.RequireHttpsMetadata = false;//����Ҫhttps����������������Ҫ����
            //        options.Audience = "ERP-API";//��Ҫ����Ȩ�������ǼǸ���Ϣ��λ��ApiScopes��

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
