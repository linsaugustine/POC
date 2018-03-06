using System;

namespace ChartNav.WaveIntegrationService.BAL.Interfaces
{
    public interface ICnWaveIntegrate
    {
        bool isChartCACed(int chartId);
        string GetCACFeedBack(int chartId);

        bool UpdateImageStatus();
        bool PostWaveXMLData();
    }
}
