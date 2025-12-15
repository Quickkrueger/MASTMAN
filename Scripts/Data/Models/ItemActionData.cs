using Godot;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MASTMAN.Scripts.Data.Models
{
    public partial class ItemActionData : Resource
    {
        [Export]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [Export]
        [JsonPropertyName("activation")]
        public ActivationType Activation { get; set; }

        [Export]
        [JsonPropertyName("detail")]
        public string Detail { get; set; }

        [Export]
        [JsonPropertyName("cost")]
        public int Cost { get; set; }

        [Export]
        [JsonPropertyName("pilot")]
        public bool Pilot { get; set; }

        [Export]
        [JsonPropertyName("synergy_locations")]
        public string[] SynergyLocations { get; set; }

        [Export]
        [JsonPropertyName("tech_attack")]
        public bool TechAttack { get; set; }

        [Export]
        [JsonPropertyName("log")]
        public string[] Log { get; set; }
    }
}
