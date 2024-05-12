using System.Text.Json.Serialization;

namespace Models
{
    public class UserData
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }

        [JsonPropertyName("support")]
        public Support Support { get; set; }

    }
}