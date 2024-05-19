using Godot;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MASTMAN.Data
{
    public partial class BonusData : Resource
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("val")]
        public object Val { get; set; }  // to accommodate both string and number

        [JsonPropertyName("damage_types")]
        public List<DamageType> DamageTypes { get; set; }

        [JsonPropertyName("range_types")]
        public List<RangeType> RangeTypes { get; set; }

        [JsonPropertyName("weapon_types")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public List<WeaponType> WeaponTypes { get; set; }

        [JsonPropertyName("weapon_sizes")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public List<WeaponSize> WeaponSizes { get; set; }

        [JsonPropertyName("overwrite")]
        public bool? Overwrite { get; set; }

        [JsonPropertyName("replace")]
        public bool? Replace { get; set; }
    }

    public enum DamageType
    {
        Kinetic,
        Energy,
        Explosive,
        Heat,
        Burn,
        Variable
    }

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
