namespace Sizmon.Agent.BusinessService.UnitTests
{
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Sizmon.Agent.BusinessService;

    [TestClass]
    public class DriveMonitorTest
    {
        [TestMethod]
        public void ShouldFindADrive()
        {
            IDriveMonitor driveMonitor = new DriveMonitor();
            var drives = driveMonitor.GetDrivesInfo();

            Assert.IsTrue(drives.Count() > 0); 
        }
    }
}
