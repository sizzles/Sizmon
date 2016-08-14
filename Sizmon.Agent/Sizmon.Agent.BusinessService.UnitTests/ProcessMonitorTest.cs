namespace Sizmon.Agent.BusinessService.UnitTests
{
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Sizmon.Agent.BusinessService;

    [TestClass]
    public class ProcessMonitorTest
    {
        [TestMethod]
        public void ShouldFindAProcess()
        {
            IProcessMonitor processMonitor = new ProcessMonitor();
            var processes = processMonitor.GetProcessInfo();

            Assert.IsTrue(processes.Count() > 0); 
        }
    }
}
