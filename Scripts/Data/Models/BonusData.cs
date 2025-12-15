using Godot;
using MASTMAN.Util;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MASTMAN.Scripts.Data.Models
{
    public partial class BonusData : Resource
    {
        [Export]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [Export]
        [JsonPropertyName("val")]
        public string ValString { get; set; }

        [Export]
        [JsonPropertyName("val")]
        public float ValNum { get; set; }

        [Export]
        [JsonPropertyName("damage_types")]
        [JsonConverter(typeof(JsonEnumListConverter<DamageType>))]
        public Godot.Collections.Array<DamageType> DamageTypes { get; set; }

        [Export]
        [JsonPropertyName("range_types")]
        [JsonConverter(typeof(JsonEnumListConverter<RangeType>))]
        public Godot.Collections.Array<RangeType> RangeTypes { get; set; }

        [Export]
        [JsonPropertyName("weapon_types")]
        [JsonConverter(typeof(JsonEnumListConverter<WeaponType>))]
        public Godot.Collections.Array<WeaponType> WeaponTypes { get; set; }

        [Export]
        [JsonPropertyName("weapon_sizes")]
        [JsonConverter(typeof(JsonEnumListConverter<WeaponSize>))]
        public Godot.Collections.Array<WeaponSize> WeaponSizes { get; set; }

        [Export]
        [JsonPropertyName("overwrite")]
        public bool Overwrite { get; set; }

        [Export]
        [JsonPropertyName("replace")]
        public bool Replace { get; set; }
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DamageType
    {
        Kinetic,
        Energy,
        Explosive,
        Heat,
        Burn,
        Variable
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RangeType
    {
        Range,
        Threat,
        Thrown,
        Line,
        Cone,
        Blast,
        Burst
    }
}
