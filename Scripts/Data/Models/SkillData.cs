using Godot;
using System.Text.Json.Serialization;

namespace MASTMAN.Scripts.Data.Models
{
    public partial class SkillData : Resource
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("detail")]
        public string Detail { get; set; }

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
