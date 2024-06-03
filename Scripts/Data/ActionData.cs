﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MASTMAN.Data
{
    public class ActionData
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("detail")]
        public string Detail { get; set; }

        [JsonPropertyName("activation")]
        public ActivationType Activation { get; set; }

        [JsonPropertyName("terse")]
        public string Terse { get; set; }

        [JsonPropertyName("pilot")]
        public bool? Pilot { get; set; }

        [JsonPropertyName("mech")]
        public bool? Mech { get; set; }

        [JsonPropertyName("synergy_locations")]
        public List<string> SynergyLocations { get; set; }

        [JsonPropertyName("confirm")]
        public List<string> Confirm { get; set; }

        [JsonPropertyName("log")]
        public string Log { get; set; }

        [JsonPropertyName("ignore_used")]
        public bool? IgnoreUsed { get; set; }

        [JsonPropertyName("heat_cost")]
        public bool? HeatCost { get; set; }
    }

    public enum ActivationType
    {
        Free,
        Protocol,
        Quick,
        Full,
        Invade,
        [JsonPropertyName("Full Tech")]
        FullTech,
        [JsonPropertyName("Quick Tech")]
        QuickTech,
        Reaction,
        Other

    }

}