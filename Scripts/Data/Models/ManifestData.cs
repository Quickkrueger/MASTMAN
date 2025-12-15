using Godot;
using System.Text.Json.Serialization;

namespace MASTMAN.Scripts.Data.Models
{
    public partial class ManifestData : Resource
    {
        [Export]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [Export]
        [JsonPropertyName("author")]
        public string Author { get; set; }

        [Export]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [Export]
        [JsonPropertyName("item_prefix")]
        public string ItemPrefix { get; set; }

        [Export]
        [JsonPropertyName("version")]
        public string Version { get; set; }

        [Export]
        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }

        [Export]
        [JsonPropertyName("website")]
        public string Website { get; set; }
    }
}
