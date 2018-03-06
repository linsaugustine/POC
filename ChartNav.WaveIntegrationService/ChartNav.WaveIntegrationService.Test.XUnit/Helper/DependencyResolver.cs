
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using ChartNav.WaveIntegrationService.Domain;
using ChartNav.WaveIntegrationService.DataProvider.IRepository;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using ChartNav.WaveIntegrationService.DataProvider.Repository;

namespace ChartNav.WaveIntegrationService.Test.XUnit.Helper
{
    

    public class DependencyResolver
    {
        private readonly IConfigurationRoot Configuration;
        private readonly IServiceProvider _serviceProvider;
        public IOptions<AppSettings> Connection { get; set; }
        public ICNWaveIntegrationRepository CNWaveIntegrationRepository;

        public DependencyResolver()
        {
            var builder = new ConfigurationBuilder()
           .AddJsonFile("testsettings.json")
           .AddEnvironmentVariables();
            Configuration = builder.Build();

            var services = new ServiceCollection();
            services.AddOptions();
            services.Configure<AppSettings>(Configuration);
            services.AddAutoMapper();
            services.AddTransient<ICNWaveIntegrationRepository, CNWaveIntegrationRepository>();
           _serviceProvider = services.BuildServiceProvider();
            Connection = _serviceProvider.GetService<IOptions<AppSettings>>();
            CNWaveIntegrationRepository = _serviceProvider.GetService<ICNWaveIntegrationRepository>();
        }

    }
}
