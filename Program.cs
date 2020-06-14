using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.Reflection;

namespace ERP_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    var assemblyName = typeof(Startup).GetTypeInfo().Assembly.FullName;

                    // webBuilder.UseStartup<Startup>();
                    webBuilder.UseStartup(assemblyName);
                });
    }
}
