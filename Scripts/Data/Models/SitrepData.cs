using System.Text.Json.Serialization;

namespace MASTMAN.Scripts.Data.Models
{
    public class SitrepData
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("pcVictory")]
        public string PcVictory { get; set; }

        [JsonPropertyName("enemyVictory")]
        public string EnemyVictory { get; set; }

        [JsonPropertyName("noVictory")]
        public string NoVictory { get; set; }

        [JsonPropertyName("deployment")]
        public string Deployment { get; set; }

        [JsonPropertyName("objective")]
        public string Objective { get; set; }

        [JsonPropertyName("extraction")]
        public string Extraction { get; set; }
    }
}
