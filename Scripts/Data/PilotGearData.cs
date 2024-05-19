using Godot;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MASTMAN.Data
{
    public partial class PilotGearData : Resource
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ItemType Type { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("effect")]
        public string Effect { get; set; }

        [JsonPropertyName("tags")]
        public List<TagValData> Tags { get; set; }

        [JsonPropertyName("range")]
        public List<RangeData> Range { get; set; }

        [JsonPropertyName("damage")]
        public List<DamageData> Damage { get; set; }

        [JsonPropertyName("actions")]
        public List<ActionData> Actions { get; set; }

        [JsonPropertyName("bonuses")]
        public List<BonusData> Bonuses { get; set; }

        [JsonPropertyName("synergies")]
        public List<SynergyData> Synergies { get; set; }

        [JsonPropertyName("deployables")]
        public List<DeployableData> Deployables { get; set; }
    }

    public enum ItemType
    {
        Weapon,
        Armor,
        Gear
    }
}
