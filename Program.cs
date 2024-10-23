    using System;
    using System.Collections.Generic;
using System.IO;
using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Logging;
using MMLib.SwaggerForOcelot.DependencyInjection;
using Serilog;

namespace APIGATEWAYSPG
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                CreateHostBuilder(args).Build().Run();
            }

            public static IHostBuilder CreateHostBuilder(string[] args) =>
                Host.CreateDefaultBuilder(args)
                .UseSerilog()  // Integrate Serilog with ASP.NET Core
                .ConfigureAppConfiguration((host,config)=>
                {
                    config.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true)
                          .AddEnvironmentVariables();
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    //webBuilder.UseKestrel();
                    webBuilder.UseContentRoot(Directory.GetCurrentDirectory());
                    //webBuilder.UseUrls("http://localhost:7000");
                    webBuilder.UseStartup<Startup>();
                });
        }
    }
