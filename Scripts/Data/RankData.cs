using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MASTMAN.Data
{
    public class RankData
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("exclusive")]
        public bool? Exclusive { get; set; }

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
    }

    public class RankedData
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("rank")]
        public int Rank { get; set; }

        [JsonPropertyName("custom")]
        public bool? Custom { get; set; }

        [JsonPropertyName("custom_desc")]
        public string CustomDesc { get; set; }

        [JsonPropertyName("custom_detail")]
        public string CustomDetail { get; set; }
    }
}
