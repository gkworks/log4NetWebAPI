using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Http;
using log4net;

namespace log4NetWebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(ValuesController));

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            string file = Path.Combine("C:\\Logs\\", "WebAPILog_"+ Guid.NewGuid() + ".log");
            Logger.ConfigureFileAppender(file);
            Log.Info("Web API Started");
            return new string[] { "value1", "value2" };
        }
    }
}