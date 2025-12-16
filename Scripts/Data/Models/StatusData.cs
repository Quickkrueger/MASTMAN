using Godot;
using System.Text.Json.Serialization;

namespace MASTMAN.Scripts.Data.Models
{
    public partial class StatusData : Resource
    {
        [Export]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [Export]
        [JsonPropertyName("icon_url")]
        public string IconUrl { get; set; }

        [Export]
        [JsonPropertyName("type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public StatusType Type { get; set; }

        [Export]
        [JsonPropertyName("effects")]
        public string Effects { get; set; }

        [Export]
        [JsonPropertyName("terse")]
        public string Terse { get; set; }

        [Export]
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
