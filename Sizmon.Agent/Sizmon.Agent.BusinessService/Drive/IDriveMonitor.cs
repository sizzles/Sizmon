namespace Sizmon.Agent.BusinessService
{
    using System.Collections.Generic;
    using Sizmon.Domain;

    public interface IDriveMonitor
    {
        IEnumerable<SizDrive> GetDrivesInfo();
    }
}
