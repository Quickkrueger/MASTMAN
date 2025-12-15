using Godot;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MASTMAN.Scripts.Data.Models
{
    public partial class AmmoData : Resource
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("cost")]
        public int? Cost { get; set; }

        [JsonPropertyName("allowed_types")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public List<WeaponType> AllowedTypes { get; set; }

        [JsonPropertyName("allowed_sizes")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public List<WeaponSize> AllowedSizes { get; set; }

        [JsonPropertyName("restricted_types")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public List<WeaponType> RestrictedTypes { get; set; }

        [JsonPropertyName("restricted_sizes")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public List<WeaponSize> RestrictedSizes { get; set; }
    }
}
