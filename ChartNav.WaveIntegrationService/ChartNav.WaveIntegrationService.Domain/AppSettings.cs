using System;
using System.Collections.Generic;
using System.Text;

namespace ChartNav.WaveIntegrationService.Domain
{
    public class AppSettings
    {
        public AppSettings()
        {
            this.DBConfigs = new DBConfig();
        }
        public DBConfig DBConfigs { get; set; }
    }

    public class DBConfig
    {
        public string CNWaveIntegrationDBConnectionstring { get; set; }
    }
}
