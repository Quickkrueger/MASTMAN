using Godot;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MASTMAN.Data
{
    public partial class FrameData : Resource
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("license_level")]
        public int LicenseLevel { get; set; } = 0;

        [JsonPropertyName("license_id")]
        public string LicenseId { get; set; }

        [JsonPropertyName("variant")]
        public string Variant { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("mechtype")]
        public List<string> MechType { get; set; } = new List<string>();

        [JsonPropertyName("specialty")]
        [JsonConverter(typeof(SpecialtyConverter))]
        public object Specialty { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("mounts")]
        public List<MountType> Mounts { get; set; } = new List<MountType>();

        [JsonPropertyName("stats")]
        public FrameStats Stats { get; set; }

        [JsonPropertyName("traits")]
        public List<FrameTraitData> Traits { get; set; } = new List<FrameTraitData>();

        [JsonPropertyName("core_system")]
        public CoreSystemData CoreSystem { get; set; }

        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }

        [JsonPropertyName("y_pos")]
        public int? YPos { get; set; }
    }

    public class FrameStats
    {
        [JsonPropertyName("size")]
        public int Size { get; set; }

        [JsonPropertyName("structure")]
        public int Structure { get; set; }

        [JsonPropertyName("stress")]
        public int Stress { get; set; }

        [JsonPropertyName("armor")]
        public int Armor { get; set; }

        [JsonPropertyName("hp")]
        public int HP { get; set; }

        [JsonPropertyName("evasion")]
        public int Evasion { get; set; }

        [JsonPropertyName("edef")]
        public int EDef { get; set; }

        [JsonPropertyName("heatcap")]
        public int HeatCap { get; set; }

        [JsonPropertyName("repcap")]
        public int RepCap { get; set; }

        [JsonPropertyName("sensor_range")]
        public int SensorRange { get; set; }

        [JsonPropertyName("tech_attack")]
        public int TechAttack { get; set; }

        [JsonPropertyName("save")]
        public int Save { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("sp")]
        public int SP { get; set; }
    }

    public enum MountType
    {
        Main,
        Heavy,
        [JsonPropertyName("Aux/Aux")]
        AuxAux,
        Aux,
        [JsonPropertyName("Main/Aux")]
        MainAux,
        Flex,
        Integrated

    }

    public class SpecialtyPrerequisite
    {
        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("min_rank")]
        public int MinRank { get; set; }

        [JsonPropertyName("cumulative")]
        public bool? Cumulative { get; set; }
    }

    public class SpecialtyConverter : JsonConverter<object>
    {
        public override object Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.True || reader.TokenType == JsonTokenType.False)
            {
                return reader.GetBoolean();
            }
            else if (reader.TokenType == JsonTokenType.StartObject)
            {
                return JsonSerializer.Deserialize<SpecialtyPrerequisite>(ref reader, options);
            }
            throw new JsonException("Invalid JSON format for Specialty property");
        }

        public override void Write(Utf8JsonWriter writer, object value, JsonSerializerOptions options)
        {
            if (value is bool booleanValue)
            {
                writer.WriteBooleanValue(booleanValue);
            }
            else if (value is SpecialtyPrerequisite prerequisite)
            {
                JsonSerializer.Serialize(writer, prerequisite, options);
            }
            else
            {
                throw new JsonException("Invalid value type for Specialty property");
            }
        }
    }

}
