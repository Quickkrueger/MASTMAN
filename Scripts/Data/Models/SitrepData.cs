using Godot;
using System.Text.Json.Serialization;

namespace MASTMAN.Scripts.Data.Models
{
    public partial class SitrepData : Resource
    {
        [Export]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [Export]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [Export]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [Export]
        [JsonPropertyName("pcVictory")]
        public string PcVictory { get; set; }

        [Export]
        [JsonPropertyName("enemyVictory")]
        public string EnemyVictory { get; set; }

        [Export]
        [JsonPropertyName("noVictory")]
        public string NoVictory { get; set; }

        [Export]
        [JsonPropertyName("deployment")]
        public string Deployment { get; set; }

        [Export]
        [JsonPropertyName("objective")]
        public string Objective { get; set; }

        [Export]
        [JsonPropertyName("extraction")]
        public string Extraction { get; set; }
    }
}
