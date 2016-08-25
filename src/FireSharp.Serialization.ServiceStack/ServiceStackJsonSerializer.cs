using FireSharp.Interfaces;
using Newtonsoft.Json;

namespace FireSharp.Serialization.ServiceStack
{
    /// <summary>
    ///     ServiceSatck JSON serializer for request bodies
    ///     ServiceStack.Text supports DataContract,DataMember attributes
    /// </summary>
    public class ServiceStackJsonSerializer : ISerializer
    {
        public T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        public string Serialize<T>(T value)
        {
            return JsonConvert.SerializeObject(value);
        }
    }
}        