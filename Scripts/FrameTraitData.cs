using Godot;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MASTMAN.Data
{
    public partial class FrameTraitData : Resource
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("use")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public UseType? Use { get; set; }

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

    public enum UseType
    {
        Turn,
        NextTurn,
        Round,
        NextRound,
        Scene,
        Encounter,
        Mission
    }
}
