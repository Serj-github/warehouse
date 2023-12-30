using System;
using System.Reflection;
using AuthorizationService.Handlers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace AuthorizationService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LogsHandler.ConfigureLogging();
            CreateHostBuilder(args).Build().Run();
        }

        private static void CreateHost(string[] args)
        {
            try
            {
                CreateHostBuilder(args).Build().Run();
            }
            catch (System.Exception ex)
            {
                Log.Fatal($"Failed to start {Assembly.GetExecutingAssembly().GetName().Name}", ex);
                throw;
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
                Host.CreateDefaultBuilder(args)
                    .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); })
                    .ConfigureAppConfiguration(configuration =>
                    {
                        configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                        configuration.AddJsonFile(
                                $"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json",
                                optional: true);
                    })
                    .UseSerilog();
    }
}