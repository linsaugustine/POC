
using System;
using System.Collections;
using System.Collections.Generic;

namespace ChartNav.WaveIntegrationService.DataProvider.IRepository
{
    public interface ICNWaveIntegrationRepository
    {
        /// <summary>
        /// Fetch CAC enabled flag
        /// </summary>
        /// <param name="ChartNavID"></param>
        /// <returns></returns>
        bool Get(int ChartNavID);//Determine if CAC enable for this Imageid

        /// <summary>
        /// Fetch CAC feedback
        /// </summary>
        /// <param name="ChartNavID"></param>
        /// <returns></returns>
        string  Get(int ChartNavID,int id);//CAC feedback retrieve state of chart when reaches terminal status

        /// <summary>
        /// Put image id staus into DB        /// </summary>
        /// <param name="chartDomain"></param>
        /// <returns></returns>
        bool Put( );//Update ImageID Status

        /// <summary>
        /// Post diagnosis data in to DB
        /// </summary>
        /// <param name="chartDomain"></param>
        /// <returns></returns>
        bool Post( );//Add Diagnossis

    }
}
