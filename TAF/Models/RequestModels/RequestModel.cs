using Newtonsoft.Json;

namespace Models
{
    public class RequestModel
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "job")]
        public string Job { get; set; }
    }
}