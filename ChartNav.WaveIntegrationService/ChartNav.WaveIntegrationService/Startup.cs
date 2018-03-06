
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ChartNav.WaveIntegrationService.Domain;
using ChartNav.WaveIntegrationService.BAL.Interfaces;
using ChartNav.WaveIntegrationService.BAL;
using ChartNav.WaveIntegrationService.DataProvider.Repository;
using ChartNav.WaveIntegrationService.DataProvider.IRepository;

namespace ChartNav.WaveIntegrationService
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();
            services.Configure<AppSettings>(Configuration);
            services.AddAutoMapper();

            services.AddTransient<ICNWaveIntegrationRepository, CNWaveIntegrationRepository>();
            services.AddTransient<ICnWaveIntegrate, CnWaveIntegrate>();
            //  services.AddTransient<ICNWaveIntegrationRepository,>
            //Register the swagger generator, defining one or more swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("ChartNav.WaveIntegrationService", new Swashbuckle.AspNetCore.Swagger.Info { Title = "ChartNav.WaveIntegrationServiceAPI", Version = "V1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            //Enable middleware to serve generated Swagger as JSON result
            app.UseSwagger();

            //Enable middleware to server Swagger -UI (HTML,JS,CSS,etc..), Specifying the Swagger

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "ChartNav.WaveIntegrationServiceAPI V1");
            });
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseMvc();
        }
    }
}
