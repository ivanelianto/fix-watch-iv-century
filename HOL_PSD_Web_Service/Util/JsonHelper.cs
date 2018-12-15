using System.Web.Script.Serialization;

namespace HOL_PSD_Web_Service.Util
{
    public class JsonHandler
    {
        private static JavaScriptSerializer jss = new JavaScriptSerializer();

        public static string Encode(object data)
        {
            return jss.Serialize(data);
        }

        public static T Decode<T>(string data)
        {
            return jss.Deserialize<T>(data);
        }
    }
}