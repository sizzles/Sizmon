namespace Sizmon.Agent.BusinessService
{
    using Sizmon.Domain;
    using System.Collections.Generic;
    using System.Linq;
    using System.ServiceProcess;

    public class ServiceMonitor : IServiceMonitor
    {
        public IEnumerable<SizService> GetServiceInfo()
        {
            ServiceController[] services = ServiceController.GetServices();

            return services.Select(service => new SizService(service));
        }

    }
}
