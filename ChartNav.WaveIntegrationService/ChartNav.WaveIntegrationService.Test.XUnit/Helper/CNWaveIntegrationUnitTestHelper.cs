using ChartNav.WaveIntegrationService.BAL;
using ChartNav.WaveIntegrationService.BAL.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChartNav.WaveIntegrationService.Test.XUnit.Helper
{
    /// <summary>
    /// 
    /// </summary>
   public  class CNWaveIntegrationUnitTestHelper
    {
        Mock<ICnWaveIntegrate> CNWaveIntegrateMoq = new Mock<ICnWaveIntegrate>();
        Mock<CnWaveIntegrate> CNWaveIntegrationMoq = new Mock<CnWaveIntegrate>();
        public CNWaveIntegrateConstructor Post()
        {
            CNWaveIntegrateConstructor resultconstructor = new CNWaveIntegrateConstructor();


            resultconstructor.CNWaveIntegration = new CnWaveIntegrate(new DependencyResolver().CNWaveIntegrationRepository);

                return resultconstructor; 
           
        }

        public class CNWaveIntegrateConstructor
        {
            public ICnWaveIntegrate CNWaveIntegrate { get; set; }

            public CnWaveIntegrate CNWaveIntegration { get; set; }

        }

    }
}
