using Godot;
using System.Text.Json.Serialization;

namespace MASTMAN.Scripts.Data.Models
{
    public partial class ManufacturerData : Resource
    {
        [Export]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [Export]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [Export]
        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        [Export]
        [JsonPropertyName("logo_url")]
        public string LogoUrl { get; set; }

        [Export]
        [JsonPropertyName("light")]
        public string Light { get; set; }

        [Export]
        [JsonPropertyName("dark")]
        public string Dark { get; set; }

        [Export]
        [JsonPropertyName("quote")]
        public string Quote { get; set; }
    }
}
