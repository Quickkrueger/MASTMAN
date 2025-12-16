using Godot;
using System.Text.Json.Serialization;

namespace MASTMAN.Scripts.Data.Models
{
    public partial class SkillData : Resource
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
        [JsonPropertyName("detail")]
        public string Detail { get; set; }

        [Export]
        [JsonPropertyName("family")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public SkillFamily Family { get; set; }
    }

    public enum SkillFamily
    {
        str,
        con,
        dex,
        @int,
        cha
    }
}
