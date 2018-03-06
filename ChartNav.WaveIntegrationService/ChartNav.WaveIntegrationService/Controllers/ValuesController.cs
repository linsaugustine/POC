using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using ChartNav.WaveIntegrationService.BAL.Interfaces;

namespace ChartNav.WaveIntegrationService.Controllers
{
    [Produces("application/json")]
    [Route("api/CNWaveIntegration")]
    public class ValuesController : Controller
    {
        private ICnWaveIntegrate _CnWaveIntegrate;
        public ValuesController(ICnWaveIntegrate CnWaveIntegrate)
        {
            this._CnWaveIntegrate = CnWaveIntegrate;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public string Post([FromBody]string value)
        {
            return string.Empty;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
