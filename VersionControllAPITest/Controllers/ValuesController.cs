using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web.Http;

namespace VersionControllAPITest.Controllers
{
    public class ValuesController : ApiController
    {
        private Assembly assembly = typeof(ValuesController).Assembly;

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        public string GetVersion()
        {
            var versionText = assembly.GetName().Version;
            return versionText.ToString();
        }

        public string GetFileVersion()
        {
           FileVersionInfo fileVersion = FileVersionInfo.GetVersionInfo(assembly.Location);
            var fileVersionText = fileVersion.FileVersion;
            return fileVersionText;
        }

        public string GetInformationalVersion()
        {
            FileVersionInfo fileVersion = FileVersionInfo.GetVersionInfo(assembly.Location);
            var productVersion = fileVersion.ProductVersion;
            return productVersion;
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
