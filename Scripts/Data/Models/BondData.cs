using Godot;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MASTMAN.Scripts.Data.Models
{
    public partial class BondData : Resource
    {
        [Export]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [Export]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [Export]
        [JsonPropertyName("major_ideals")]
        public string[] MajorIdeals { get; set; }

        [Export]
        [JsonPropertyName("minor_ideals")]
        public string[] MinorIdeals { get; set; }

        [Export]
        [JsonPropertyName("questions")]
        public Question[] Questions { get; set; }

        [Export]
        [JsonPropertyName("powers")]
        public BondPower[] Powers { get; set; }
    }

    public partial class Question : Resource
    {
        [Export]
        [JsonPropertyName("question")]
        public string Text { get; set; }

        [Export]
        [JsonPropertyName("options")]
        public string[] Options { get; set; }
    }

    public partial class BondPower : Resource
    {
        [Export]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [Export]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [Export]
        [JsonPropertyName("frequency")]
        public string Frequency { get; set; }

        [Export]
        [JsonPropertyName("prerequisite")]
        public string Prerequisite { get; set; }

        [Export]
        [JsonPropertyName("veteran")]
        public bool Veteran { get; set; }

        [Export]
        [JsonPropertyName("master")]
        public bool Master { get; set; }
    }

    public partial class PilotBondData : Resource
    {
        [Export]
        [JsonPropertyName("bondId")]
        public string BondId { get; set; }

        [Export]
        [JsonPropertyName("xp")]
        public int Xp { get; set; }

        [Export]
        [JsonPropertyName("stress")]
        public int Stress { get; set; }

        [Export]
        [JsonPropertyName("maxStress")]
        public int MaxStress { get; set; }

        [Export]
        [JsonPropertyName("powerSelections")]
        public int PowerSelections { get; set; }

        [Export]
        [JsonPropertyName("isBroken")]
        public bool IsBroken { get; set; }

        [Export]
        [JsonPropertyName("burdens")]
        public ClockData[] Burdens { get; set; }

        [Export]
        [JsonPropertyName("bondPowers")]
        public BondPower[] BondPowers { get; set; }

        [Export]
        [JsonPropertyName("clocks")]
        public ClockData[] Clocks { get; set; }

        [Export]
        [JsonPropertyName("minorIdeal")]
        public string MinorIdeal { get; set; }

        [Export]
        [JsonPropertyName("bondAnswers")]
        public string[] BondAnswers { get; set; }
    }
}
