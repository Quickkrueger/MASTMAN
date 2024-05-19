using Godot;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MASTMAN.Data
{
    public partial class CoreSystemData : Resource
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("active_name")]
        public string ActiveName { get; set; }

        [JsonPropertyName("active_effect")]
        public string ActiveEffect { get; set; }

        [JsonPropertyName("activation")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ActivationType Activation { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("deactivation")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ActivationType? Deactivation { get; set; }

        [JsonPropertyName("use")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public UseType? Use { get; set; }

        [JsonPropertyName("active_actions")]
        public List<ActionData> ActiveActions { get; set; }

        [JsonPropertyName("active_bonuses")]
        public List<BonusData> ActiveBonuses { get; set; }

        [JsonPropertyName("active_synergies")]
        public List<SynergyData> ActiveSynergies { get; set; }

        [JsonPropertyName("passive_name")]
        public string PassiveName { get; set; }

        [JsonPropertyName("passive_effect")]
        public string PassiveEffect { get; set; }

        [JsonPropertyName("passive_actions")]
        public List<ActionData> PassiveActions { get; set; }

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
