using AutoMapper;
using ChartNav.WaveIntegrationService.DataProvider.IRepository;
using ChartNav.WaveIntegrationService.Domain;
using Microsoft.Extensions.Options;
using System;

namespace ChartNav.WaveIntegrationService.DataProvider.Repository
{
    public class CNWaveIntegrationRepository : ICNWaveIntegrationRepository
    {
        //public readonly DBConfig connection;
        private readonly DBConfig connection;
        private readonly IMapper _mapper;
        public CNWaveIntegrationRepository(IOptions<AppSettings> strings, IMapper mapper)
        {
            connection = strings.Value.DBConfigs;
            _mapper = mapper;
        }

        /// <summary>
        /// Find out the Chart is CACd or not
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool Get(int Id)
        {
            return true;
        }
        public string Get(int ChartNavID, int id)//CAC feedback retrieve state of chart when reaches terminal status
        {

            return string.Empty;
        }

        /// <summary>
        /// Put image id staus into DB        /// </summary>
        /// <param name="chartDomain"></param>
        /// <returns></returns>
        public bool Put()//Update ImageID Status
        {
            return true;
        }
        /// <summary>
        /// Post diagnosis data in to DB
        /// </summary>
        /// <param name="chartDomain"></param>
        /// <returns></returns>
        public bool Post()//Add Diagnossis
        {
            return true;
        }
    }
}
