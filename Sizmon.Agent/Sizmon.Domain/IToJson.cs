namespace Sizmon.Domain
{
    using Newtonsoft.Json.Linq;

    public interface IToJson
    {
         JObject ToJson();
    }
}
