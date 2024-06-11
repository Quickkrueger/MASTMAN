using System.Text.Json.Serialization;

namespace MASTMAN.Data
{
    public class CounterData
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("level")]
        public int? Level { get; set; }

        [JsonPropertyName("min")]
        public int? Min { get; set; }

        [JsonPropertyName("max")]
        public int? Max { get; set; }

        [JsonPropertyName("default_value")]
        public int? DefaultValue { get; set; }

        [JsonPropertyName("custom")]
        public bool Custom { get; set; }
    }

    public class CounterSaveData
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("val")]
        public int Value { get; set; }
    }
}
