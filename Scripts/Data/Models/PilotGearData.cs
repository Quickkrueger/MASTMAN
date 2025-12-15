using MASTMAN.Util;
using Godot;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MASTMAN.Scripts.Data.Models
{
    public partial class PilotGearData : Resource
    {
        [Export]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [Export]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [Export]
        [JsonPropertyName("type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ItemType Type { get; set; }

        [Export]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [Export]
        [JsonPropertyName("effect")]
        public string Effect { get; set; }

        [Export]
        [JsonPropertyName("tags")]
        public TagValData[] Tags { get; set; }

        [Export]
        [JsonPropertyName("range")]
        public RangeData[] Range { get; set; }

        [Export]
        [JsonPropertyName("damage")]
        public DamageData[] Damage { get; set; }

        [Export]
        [JsonPropertyName("actions")]
        public ItemActionData[] Actions { get; set; }

        [Export]
        [JsonPropertyName("bonuses")]
        public BonusData[] Bonuses { get; set; }

        [Export]
        [JsonPropertyName("synergies")]
        public SynergyData[] Synergies { get; set; }

        [Export]
        [JsonPropertyName("deployables")]
        public DeployableData[] Deployables { get; set; }
    }

    public enum ItemType
    {
        Weapon,
        Armor,
        Gear
    }
}
