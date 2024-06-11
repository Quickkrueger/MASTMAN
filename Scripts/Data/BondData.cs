using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MASTMAN.Data
{
    public class BondData
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("major_ideals")]
        public List<string> MajorIdeals { get; set; }

        [JsonPropertyName("minor_ideals")]
        public List<string> MinorIdeals { get; set; }

        [JsonPropertyName("questions")]
        public List<Question> Questions { get; set; }

        [JsonPropertyName("powers")]
        public List<BondPower> Powers { get; set; }
    }

    public class Question
    {
        [JsonPropertyName("question")]
        public string Text { get; set; }

        [JsonPropertyName("options")]
        public List<string> Options { get; set; }
    }

    public class BondPower
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("frequency")]
        public string Frequency { get; set; }

        [JsonPropertyName("prerequisite")]
        public string Prerequisite { get; set; }

        [JsonPropertyName("veteran")]
        public bool? Veteran { get; set; }

        [JsonPropertyName("master")]
        public bool? Master { get; set; }
    }

    public class PilotBondData
    {
        [JsonPropertyName("bondId")]
        public string BondId { get; set; }

        [JsonPropertyName("xp")]
        public int Xp { get; set; }

        [JsonPropertyName("stress")]
        public int Stress { get; set; }

        [JsonPropertyName("maxStress")]
        public int MaxStress { get; set; }

        [JsonPropertyName("powerSelections")]
        public int PowerSelections { get; set; }

        [JsonPropertyName("isBroken")]
        public bool IsBroken { get; set; }

        [JsonPropertyName("burdens")]
        public List<ClockData> Burdens { get; set; }

        [JsonPropertyName("bondPowers")]
        public List<BondPower> BondPowers { get; set; }

        [JsonPropertyName("clocks")]
        public List<ClockData> Clocks { get; set; }

        [JsonPropertyName("minorIdeal")]
        public string MinorIdeal { get; set; }

        [JsonPropertyName("bondAnswers")]
        public List<string> BondAnswers { get; set; }
    }
}
