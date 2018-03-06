using ChartNav.WaveIntegrationService.Controllers;
using ChartNav.WaveIntegrationService.Test.XUnit.Helper;
using System;
using Xunit;

namespace ChartNav.WaveIntegrationService.Test.XUnit
{
    public class WaveIntegrationServiceTest
    {
        private CNWaveIntegrationUnitTestHelper _CNWaveIntegrationUnitTestHelper;
        [Fact]
        public void TestPost()
        {
            CNWaveIntegrationUnitTestHelper _cNWaveIntegrationUnitTestHelper = new CNWaveIntegrationUnitTestHelper();
            var val = _cNWaveIntegrationUnitTestHelper.Post();
            var controller = new ValuesController(val.CNWaveIntegrate);
            var result = controller.Post("");
            Assert.Equal("1", result);
        }
    }
}
