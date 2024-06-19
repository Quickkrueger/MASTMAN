using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MASTMAN.Scripts.Data.Models
{
    public class CoreSystemData
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("active_name")]
        public string ActiveName { get; set; }

        [JsonPropertyName("active_effect")]
        public string ActiveEffect { get; set; }

        [JsonPropertyName("activation")]
        public ActivationType Activation { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("deactivation")]
        public ActivationType Deactivation { get; set; }

        [JsonPropertyName("use")]
        public UseType Use { get; set; }

        [JsonPropertyName("active_actions")]
        public List<ItemActionData> ActiveActions { get; set; }

        [JsonPropertyName("active_bonuses")]
        public List<BonusData> ActiveBonuses { get; set; }

        [JsonPropertyName("active_synergies")]
        public List<SynergyData> ActiveSynergies { get; set; }

        [JsonPropertyName("passive_name")]
        public string PassiveName { get; set; }

        [JsonPropertyName("passive_effect")]
        public string PassiveEffect { get; set; }

        [JsonPropertyName("passive_actions")]
        public List<ItemActionData> PassiveActions { get; set; }

        [JsonPropertyName("passive_bonuses")]
        public List<BonusData> PassiveBonuses { get; set; }

        [JsonPropertyName("passive_synergies")]
        public List<SynergyData> PassiveSynergies { get; set; }

        [JsonPropertyName("deployables")]
        public List<DeployableData> Deployables { get; set; }

        [JsonPropertyName("counters")]
        public List<CounterData> Counters { get; set; }

        [JsonPropertyName("integrated")]
        public List<string> Integrated { get; set; }

        [JsonPropertyName("special_equipment")]
        public List<string> SpecialEquipment { get; set; }

        [JsonPropertyName("tags")]
        public List<TagValData> Tags { get; set; }
    }
}
