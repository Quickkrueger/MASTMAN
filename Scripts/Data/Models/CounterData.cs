using Godot;
using System.Text.Json.Serialization;

namespace MASTMAN.Scripts.Data.Models
{
    public partial class CounterData : Resource
    {
        [Export]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [Export]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [Export]
        [JsonPropertyName("level")]
        public int Level { get; set; }

        [Export]
        [JsonPropertyName("min")]
        public int Min { get; set; }

        [Export]
        [JsonPropertyName("max")]
        public int Max { get; set; }

        [Export]
        [JsonPropertyName("default_value")]
        public int DefaultValue { get; set; }

        [Export]
        [JsonPropertyName("custom")]
        public bool Custom { get; set; }
    }

    public partial class CounterSaveData : Resource
    {
        [Export]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [Export]
        [JsonPropertyName("val")]
        public int Value { get; set; }
    }
}
