namespace Sizmon.Domain
{
    using System.IO;
    using Newtonsoft.Json.Linq;

    public class SizDrive : IToJson
    {
        private readonly DriveInfo driveInfo;
        public SizDrive(DriveInfo driveInfo)
        {
            this.driveInfo = driveInfo;
        }

        public JObject ToJson()
        {
            if (driveInfo != null)
            {
                var json = new JObject();

                json["DriveName"] = driveInfo.Name.ToString();
                json["AvaialbleFreeSpace"] = driveInfo.AvailableFreeSpace;
                json["TotalSize"] = driveInfo.TotalSize;
                json["DriveFormat"] = driveInfo.DriveFormat;

                return json;
            }

            else
                return null;
        }
    }
}
