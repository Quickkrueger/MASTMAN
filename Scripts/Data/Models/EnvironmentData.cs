using System.Text.Json.Serialization;

namespace MASTMAN.Scripts.Data.Models
{
    public class EnvironmentData
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
