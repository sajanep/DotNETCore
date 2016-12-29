using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using DotNetCoreWebApiSample.Models;

namespace DotNetCoreWebApiSample.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private ILogger<ValuesController> logger;

        private MySettings mySettingsAccessor;

        public ValuesController(ILogger<ValuesController> logger, IOptions<MySettings> mySettingsAccessor)
        {
            this.logger = logger;
            this.mySettingsAccessor = mySettingsAccessor.Value;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            logger.LogInformation("Retrieving values inside ValuesController/Get");
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
        public void Post([FromBody]string value)
        {
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

        [HttpGet("GetAppSettings")]
        public IEnumerable<string> GetAppSettings()
        {
            var applicationName = mySettingsAccessor.ApplicationName;
            var fileUploadMaxSize = mySettingsAccessor.FileUploadMaxSize;
            var fileUploadPath = mySettingsAccessor.FileUploadPath;
            return new string[] {
                $"ApplicationName = {applicationName}",
                $"FileUploadMaxSize = {fileUploadMaxSize}",
                $"FileUploadPath = {fileUploadPath}"
            };
        }
    }
}
