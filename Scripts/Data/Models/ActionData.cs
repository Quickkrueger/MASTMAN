using Godot;
using MASTMAN.Util;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace MASTMAN.Scripts.Data.Models
{
    [GlobalClass]
    public partial class ActionData : Resource
    {
        [Export]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [Export]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [Export]
        [JsonPropertyName("detail")]
        public string Detail { get; set; }

        [Export]
        [JsonPropertyName("activation")]
        public ActivationType Activation { get; set; }

        [Export]
        [JsonPropertyName("terse")]
        public string Terse { get; set; }

        [Export]
        [JsonPropertyName("pilot")]
        public bool Pilot { get; set; }

        [Export]
        [JsonPropertyName("mech")]
        public bool Mech { get; set; }

        [Export]
        [JsonPropertyName("synergy_locations")]
        public string[] SynergyLocations { get; set; }

        [Export]
        [JsonPropertyName("confirm")]
        public string[] Confirm { get; set; }

        [Export]
        [JsonPropertyName("log")]
        public string Log { get; set; }

        [Export]
        [JsonPropertyName("ignore_used")]
        public bool IgnoreUsed { get; set; }

        [Export]
        [JsonPropertyName("heat_cost")]
        public bool HeatCost { get; set; }

        public override string ToString()
        {
            string output = "{\n";
            output += $"\t{Id}\n";
            output += $"\t{Name}\n";
            output += $"\t{Detail}\n";
            output += $"\t{Activation}\n";
            output += Terse != null ? $"\t{Terse}\n" : "";
            output += Pilot != null ? $"\t{Pilot}\n" : "";
            output += Mech != null ? $"\t{Mech}\n" : "";
            output += SynergyLocations != null && SynergyLocations.Length > 0 ? $"\t{LogHelper.ToStringList(SynergyLocations.ToList())}\n" : "";
            output += Confirm != null && Confirm.Length > 0 ? $"\t{LogHelper.ToStringList(Confirm.ToList())}\n" : "";
            output += Log != null ? $"\t{Log}\n" : "";
            output += IgnoreUsed != null ? $"\t{IgnoreUsed}\n" : "";
            output += HeatCost != null ? $"\t{HeatCost}\n" : "";
            output += "}";
            return output;
        }
    }

    [JsonConverter(typeof(JsonEnumMemberStringEnumConverter<ActivationType>))]
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
        Move,
        Downtime,
        Other

    }

}
