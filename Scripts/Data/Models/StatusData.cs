using Godot;
using System.Text.Json.Serialization;

namespace MASTMAN.Scripts.Data.Models
{
    public partial class StatusData : Resource
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("icon_url")]
        public string IconUrl { get; set; }

        [JsonPropertyName("type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public StatusType Type { get; set; }

        [JsonPropertyName("effects")]
        public string Effects { get; set; }

        [JsonPropertyName("terse")]
        public string Terse { get; set; }

        [JsonPropertyName("exclusive")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ExclusivityType Exclusive { get; set; }
    }

    public enum StatusType
    {
        Status,
        Condition
    }

    public enum ExclusivityType
    {
        None,
        Mech,
        Pilot
    }
}
