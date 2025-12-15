using Godot;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MASTMAN.Scripts.Data.Models
{
    public partial class AmmoData : Resource
    {
        [Export]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [Export]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [Export]
        [JsonPropertyName("cost")]
        public int Cost { get; set; }

        [Export]
        [JsonPropertyName("allowed_types")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Godot.Collections.Array<WeaponType> AllowedTypes { get; set; }

        [Export]
        [JsonPropertyName("allowed_sizes")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Godot.Collections.Array<WeaponSize> AllowedSizes { get; set; }

        [Export]
        [JsonPropertyName("restricted_types")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Godot.Collections.Array<WeaponType> RestrictedTypes { get; set; }

        [Export]
        [JsonPropertyName("restricted_sizes")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Godot.Collections.Array<WeaponSize> RestrictedSizes { get; set; }
    }
}
