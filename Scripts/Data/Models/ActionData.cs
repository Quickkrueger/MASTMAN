using Godot;
using MASTMAN.Util;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace MASTMAN.Scripts.Data.Models
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
            output += SynergyLocations != null && SynergyLocations.Count > 0 ? $"\t{LogHelper.ToStringList(SynergyLocations)}\n" : "";
            output += Confirm != null && Confirm.Count > 0 ? $"\t{LogHelper.ToStringList(Confirm)}\n" : "";
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
