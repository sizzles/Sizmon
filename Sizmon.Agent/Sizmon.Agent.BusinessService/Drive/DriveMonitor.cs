namespace Sizmon.Agent.BusinessService
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using Sizmon.Domain;

    public class DriveMonitor : IDriveMonitor
    {
        public IEnumerable<SizDrive> GetDrivesInfo()
        {
            var driveInfoArray = DriveInfo.GetDrives();

            return driveInfoArray.Select(drive => new SizDrive(drive));
        }
    }
}
