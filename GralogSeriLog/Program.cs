using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using Microsoft.Extensions.Logging;

namespace GralogSeriLog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
              .AddJsonFile("appsettings.json")
              .Build();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .CreateLogger();

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseSerilog()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        //public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        //  WebHost.CreateDefaultBuilder(args)
        //  .UseStartup<Startup>()
        //  .ConfigureLogging(loggingConfiguration => loggingConfiguration.ClearProviders())
        //  .UseSerilog((hostingContext, loggerConfiguration) =>
        //      loggerConfiguration.ReadFrom.Configuration(hostingContext.Configuration));
    }
}
