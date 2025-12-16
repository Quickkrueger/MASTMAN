using MASTMAN.Util;
using Godot;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MASTMAN.Scripts.Data.Models
{
    public partial class SynergyData : Resource
    {
        [Export]
        [JsonPropertyName("locations")]
        public string[] Locations { get; set; }

        [Export]
        [JsonPropertyName("detail")]
        public string Detail { get; set; }

        [Export]
        [JsonPropertyName("weapon_types")]
        [JsonConverter(typeof(JsonEnumListConverter<WeaponType>))]
        public Godot.Collections.Array<WeaponType> WeaponTypes { get; set; }

        [Export]
        [JsonPropertyName("system_types")]
        [JsonConverter(typeof(JsonEnumListConverter<SystemType>))]
        public Godot.Collections.Array<SystemType> SystemTypes { get; set; }

        [Export]
        [JsonPropertyName("weapon_sizes")]
        [JsonConverter(typeof(JsonEnumListConverter<WeaponSize>))]
        public Godot.Collections.Array<WeaponSize> WeaponSizes { get; set; }
    }
}
