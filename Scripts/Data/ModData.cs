using Godot;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MASTMAN.Data
{
    public partial class ModData : Resource
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("license")]
        public string License { get; set; }

        [JsonPropertyName("license_id")]
        public string LicenseId { get; set; }

        [JsonPropertyName("license_level")]
        public int LicenseLevel { get; set; }

        [JsonPropertyName("sp")]
        public int? Sp { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("effect")]
        public string Effect { get; set; }

        [JsonPropertyName("tags")]
        public List<TagValData> Tags { get; set; }

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

        [JsonPropertyName("added_tags")]
        public List<TagValData> AddedTags { get; set; }

        [JsonPropertyName("added_damage")]
        public List<DamageData> AddedDamage { get; set; }

        [JsonPropertyName("added_range")]
        public List<RangeData> AddedRange { get; set; }

        [JsonPropertyName("actions")]
        public List<ActionData> Actions { get; set; }

        [JsonPropertyName("bonuses")]
        public List<BonusData> Bonuses { get; set; }

        [JsonPropertyName("synergies")]
        public List<SynergyData> Synergies { get; set; }

        [JsonPropertyName("deployables")]
        public List<DeployableData> Deployables { get; set; }

        [JsonPropertyName("counters")]
        public List<CounterData> Counters { get; set; }

        [JsonPropertyName("integrated")]
        public List<string> Integrated { get; set; }

        [JsonPropertyName("special_equipment")]
        public List<string> SpecialEquipment { get; set; }

    }

    public class DamageData
    {
        // Define properties for DamageData
    }

    public class RangeData
    {
        // Define properties for RangeData
    }
}
