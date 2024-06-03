using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MASTMAN.Data
{
    public class WeaponProfileData
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("effect")]
        public string Effect { get; set; }

        [JsonPropertyName("skirmish")]
        public bool? Skirmish { get; set; }

        [JsonPropertyName("barrage")]
        public bool? Barrage { get; set; }

        [JsonPropertyName("cost")]
        public int? Cost { get; set; }

        [JsonPropertyName("on_attack")]
        public string OnAttack { get; set; }

        [JsonPropertyName("on_hit")]
        public string OnHit { get; set; }

        [JsonPropertyName("on_crit")]
        public string OnCrit { get; set; }

        [JsonPropertyName("damage")]
        public List<DamageData> Damage { get; set; }

        [JsonPropertyName("range")]
        public List<RangeData> Range { get; set; }

        [JsonPropertyName("actions")]
        public List<ItemActionData> Actions { get; set; }

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
}
