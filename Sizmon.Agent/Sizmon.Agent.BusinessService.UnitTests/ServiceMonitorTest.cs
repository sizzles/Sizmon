namespace Sizmon.Agent.BusinessService.UnitTests
{
    using System;
    using System.Collections;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Sizmon.Agent.BusinessService;

    [TestClass]
    public class ServiceMonitorTest
    {
        [TestMethod]
        public void ShouldFindAServices()
        {
            IServiceMonitor serviceMonitor = new ServiceMonitor();
            var services = serviceMonitor.GetServiceInfo();

            Assert.IsTrue(services.Count() > 0);
        }
    }
}
