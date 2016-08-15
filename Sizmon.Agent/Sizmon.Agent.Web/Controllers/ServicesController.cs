namespace Sizmon.Agent.Web.Controllers
{
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json.Linq;
    using Sizmon.Agent.BusinessService;

    [Route("api/[controller]")]
    public class ServicesController : Controller
    {      
        private IServiceMonitor serviceMonitor;

        public ServicesController()
        {
            this.serviceMonitor = new ServiceMonitor();
        }

        [HttpGet]
        public string Get()
        {
            var serviceInfo = serviceMonitor.GetServiceInfo();
            var serviceArray = new JArray(serviceInfo.Select(service => service.ToJson()));

            var result = new JObject();
            result.Add("Services", serviceArray);

            return result.ToString();
        }
    }
}
