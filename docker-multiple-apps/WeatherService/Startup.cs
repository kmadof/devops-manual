using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Settings.Configuration;

namespace WeatherService
{
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
            _logentriesToken = Configuration.GetValue<string>("LogentriesToken");
            _logentriesUrl = Configuration.GetValue<string>("LogentriesUrl");
            
            var logger = new LoggerConfiguration()
                .ReadFrom.Configuration(Configuration)
                .WriteTo.Logentries(
                token:_logentriesToken, 
                outputTemplate: $"[{{Timestamp:HH:mm:ss}} {Environment.MachineName}/Weather {{Level:u3}}] {{Message:lj}}{{Exception}}",
                url:_logentriesUrl) 
                .CreateLogger();

            _logger = logger;

            logger.Debug($"Got token and url: {_logentriesToken}, {_logentriesUrl}");
            
            services.AddLogging(
                configure =>
                {
                    configure.AddSerilog(logger);
                });

            services.AddCors(options =>
            {
                var cors = new CorsSettings();
                Configuration.Bind("CORS", cors);

                options.AddPolicy("pipeline-service",
                builder =>
                {
                    builder
                        .WithOrigins(cors.AllowOrigins.ToArray())
                        .WithMethods(cors.AllowMethods.ToArray())
                        .AllowAnyHeader();
                });
            });
            
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostApplicationLifetime apl, IWebHostEnvironment env, ILogger<Startup> logger)
        {
            logger.LogDebug($"In {env.EnvironmentName} environment");

            apl.ApplicationStopping.Register(OnApplicationStopping);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Write streamlined request completion events, instead of the more verbose ones from the framework.
            // To use the default framework request logging instead, remove this line and set the "Microsoft"
            // level in appsettings.json to "Information".
            // app.UseSerilogRequestLogging();

            app.UseCors("pipeline-service");

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            logger.LogDebug($"Finished configure. Starting up.");
        }

        private void OnApplicationStopping()
        {
            _logger?.Debug($"Application Stopping.");
        }

        private Serilog.Core.Logger _logger;
        private string _logentriesToken = null;
        private string _logentriesUrl = null;
    }

    public class CorsSettings
    {
        public List<string> AllowOrigins { get; set; }
        public List<string> AllowMethods { get; set; }
    }
}
