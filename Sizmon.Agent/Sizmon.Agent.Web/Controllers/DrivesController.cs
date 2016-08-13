namespace Sizmon.Agent.Web.Controllers
{
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json.Linq;
    using Sizmon.Agent.BusinessService;
    
    [Route("api/[controller]")]
    public class DrivesController : Controller
    {
        private readonly IDriveMonitor monitorDrive;

        public DrivesController()
        {
            this.monitorDrive = new DriveMonitor();
        }

        [HttpGet]
        public string Get()
        {
            var drivesInfo = monitorDrive.GetDrivesInfo();
            var driveArray = new JArray(drivesInfo.Select(drive => drive.ToJson()));

            var result = new JObject();
            result.Add("Drives", driveArray);

            return result.ToString();
        }
    }
}
