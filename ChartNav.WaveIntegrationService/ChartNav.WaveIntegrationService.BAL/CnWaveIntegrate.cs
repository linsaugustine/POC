using ChartNav.WaveIntegrationService.BAL.Interfaces;
using ChartNav.WaveIntegrationService.DataProvider.IRepository;
using System;

namespace ChartNav.WaveIntegrationService.BAL
{
    public class CnWaveIntegrate : ICnWaveIntegrate
    {
        private ICNWaveIntegrationRepository _cnWaveIntegrationRepository;
        public CnWaveIntegrate(ICNWaveIntegrationRepository cnwaveIntegrationRepository)
        {
            this._cnWaveIntegrationRepository = cnwaveIntegrationRepository;
        }

        public bool isChartCACed(int chartId)
        { return true; }
        public string GetCACFeedBack(int chartId)
        {
            return string.Empty;
        }

        public bool UpdateImageStatus()
        {
            return true;
        }
        public bool PostWaveXMLData()
        {
            return true;
        }

    }
}
