using Godot;
using System.Text.Json.Serialization;

namespace MASTMAN.Data
{
    public partial class EnvironmentData : Resource
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
