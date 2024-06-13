using MASTMAN.Util;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MASTMAN.Data
{
    public class BonusData
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("val")]
        public object Val { get; set; }  // to accommodate both string and number

        [JsonPropertyName("damage_types")]
        [JsonConverter(typeof(JsonEnumListConverter<DamageType>))]
        public List<DamageType> DamageTypes { get; set; }

        [JsonPropertyName("range_types")]
        [JsonConverter(typeof(JsonEnumListConverter<RangeType>))]
        public List<RangeType> RangeTypes { get; set; }

        [JsonPropertyName("weapon_types")]
        [JsonConverter(typeof(JsonEnumListConverter<WeaponType>))]
        public List<WeaponType> WeaponTypes { get; set; }

        [JsonPropertyName("weapon_sizes")]
        [JsonConverter(typeof(JsonEnumListConverter<WeaponSize>))]
        public List<WeaponSize> WeaponSizes { get; set; }

        [JsonPropertyName("overwrite")]
        public bool Overwrite { get; set; }

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
