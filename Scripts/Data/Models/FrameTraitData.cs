using MASTMAN.Util;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace MASTMAN.Scripts.Data.Models
{
    public class FrameTraitData
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("use")]
        public UseType Use { get; set; }

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

    [JsonConverter(typeof(JsonEnumMemberStringEnumConverter<UseType>))]
    public enum UseType
    {
        Free,
        Turn,
        [JsonPropertyName("Next Turn")]
        NextTurn,
        Round,
        [JsonPropertyName("Next Round")]
        NextRound,
        Scene,
        Encounter,
        Mission
    }
}
