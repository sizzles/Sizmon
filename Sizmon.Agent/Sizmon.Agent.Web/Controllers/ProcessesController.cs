namespace Sizmon.Agent.Web.Controllers
{
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json.Linq;
    using Sizmon.Agent.BusinessService;

    [Route("api/[controller]")]
    public class ProcessesController : Controller
    {
        private IProcessMonitor processMonitor;

        public ProcessesController()
        {
            this.processMonitor = new ProcessMonitor();
        }

        [HttpGet]
        public string Get()
        {
            var processInfo = processMonitor.GetProcessInfo();
            var processArray = new JArray(processInfo.Select(process => process.ToJson()));

            var result = new JObject();
            result.Add("Processes", processArray);

            return result.ToString();
        }
    }
}
