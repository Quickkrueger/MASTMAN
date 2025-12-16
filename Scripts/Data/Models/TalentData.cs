using Godot;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MASTMAN.Scripts.Data.Models
{
    public partial class TalentData : Resource
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
        [JsonPropertyName("ranks")]
        public RankData[] Ranks { get; set; }

        [Export]
        [JsonPropertyName("icon_url")]
        public string IconUrl { get; set; }

        [Export]
        [JsonPropertyName("terse")]
        public string Terse { get; set; }
    }
}
