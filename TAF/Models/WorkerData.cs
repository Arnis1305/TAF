using System.Text.Json.Serialization;

namespace Models
{
    public class WorkerData
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("job")]
        public string Job { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("updatedAt")]
        public string UpdatedAt { get; set; }
    }
}