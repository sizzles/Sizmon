namespace Sizmon.Agent.BusinessService
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using Sizmon.Domain;

    public class ProcessMonitor : IProcessMonitor
    {
        public IEnumerable<SizProcess> GetProcessInfo()
        {
            Process[] runningProcesses = Process.GetProcesses();

            return runningProcesses.Select(process => new SizProcess(process));
        }
    }
}

