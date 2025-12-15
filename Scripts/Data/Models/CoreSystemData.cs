using Godot;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MASTMAN.Scripts.Data.Models
{
    public partial class CoreSystemData : Resource
    {
        [Export]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [Export]
        [JsonPropertyName("active_name")]
        public string ActiveName { get; set; }

        [Export]
        [JsonPropertyName("active_effect")]
        public string ActiveEffect { get; set; }

        [Export]
        [JsonPropertyName("activation")]
        public ActivationType Activation { get; set; }

        [Export]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [Export]
        [JsonPropertyName("deactivation")]
        public ActivationType Deactivation { get; set; }

        [Export]
        [JsonPropertyName("use")]
        public UseType Use { get; set; }

        [Export]
        [JsonPropertyName("active_actions")]
        public ItemActionData[] ActiveActions { get; set; }

        [Export]
        [JsonPropertyName("active_bonuses")]
        public BonusData[] ActiveBonuses { get; set; }

        [Export]
        [JsonPropertyName("active_synergies")]
        public SynergyData[] ActiveSynergies { get; set; }

        [Export]
        [JsonPropertyName("passive_name")]
        public string PassiveName { get; set; }

        [Export]
        [JsonPropertyName("passive_effect")]
        public string PassiveEffect { get; set; }

        [Export]
        [JsonPropertyName("passive_actions")]
        public ItemActionData[] PassiveActions { get; set; }

        [Export]
        [JsonPropertyName("passive_bonuses")]
        public BonusData[] PassiveBonuses { get; set; }

        [Export]
        [JsonPropertyName("passive_synergies")]
        public SynergyData[] PassiveSynergies { get; set; }

        [Export]
        [JsonPropertyName("deployables")]
        public DeployableData[] Deployables { get; set; }

        [Export]
        [JsonPropertyName("counters")]
        public CounterData[] Counters { get; set; }

        [Export]
        [JsonPropertyName("integrated")]
        public string[] Integrated { get; set; }

        [Export]
        [JsonPropertyName("special_equipment")]
        public string[] SpecialEquipment { get; set; }

        [Export]
        [JsonPropertyName("tags")]
        public TagValData[] Tags { get; set; }
    }
}
