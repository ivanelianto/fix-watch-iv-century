using Newtonsoft.Json;
using System.Web.Script.Serialization;

namespace HOL_PSD_Web_Service.Util
{
    public class JsonHandler
    {
        private static JavaScriptSerializer jss = new JavaScriptSerializer();

        public static string Encode(object data)
        {
            return JsonConvert.SerializeObject(data);
        }

        public static T Decode<T>(string data)
        {
            return JsonConvert.DeserializeObject<T>(data);
        }
    }
}