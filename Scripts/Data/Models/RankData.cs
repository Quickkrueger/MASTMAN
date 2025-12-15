using Godot;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MASTMAN.Scripts.Data.Models
{
    public partial class RankData : Resource
    {
        [Export]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [Export]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [Export]
        [JsonPropertyName("exclusive")]
        public bool Exclusive { get; set; }

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

        [Export]
        [JsonPropertyName("counters")]
        public CounterData[] Counters { get; set; }

        [Export]
        [JsonPropertyName("integrated")]
        public string[] Integrated { get; set; }
    }

    public partial class RankedData : Resource
    {
        [Export]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [Export]
        [JsonPropertyName("rank")]
        public int Rank { get; set; }

        [Export]
        [JsonPropertyName("custom")]
        public bool Custom { get; set; }

        [Export]
        [JsonPropertyName("custom_desc")]
        public string CustomDesc { get; set; }

        [Export]
        [JsonPropertyName("custom_detail")]
        public string CustomDetail { get; set; }
    }
}
