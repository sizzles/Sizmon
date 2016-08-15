namespace Sizmon.Domain
{
    using System.ServiceProcess;
    using Newtonsoft.Json.Linq;

    public class SizService : IToJson
    {
        private readonly ServiceController serviceInfo;

        public SizService(ServiceController serviceInfo)
        {
            this.serviceInfo = serviceInfo;
        }

        public JObject ToJson()
        {
            if (serviceInfo != null)
            {
                var json = new JObject();

                json["ServiceName"] = serviceInfo.ServiceName;
                json["DisplayName"] = serviceInfo.DisplayName;
                json["Status"] = serviceInfo.Status.ToString();
                json["MachineName"] = serviceInfo.MachineName;

                return json;
            }

            else
                return null;
        }
    }
}
