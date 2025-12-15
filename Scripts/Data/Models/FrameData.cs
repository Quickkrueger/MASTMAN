using MASTMAN.Util;
using System;
using System.Collections.Generic;
using Godot;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MASTMAN.Scripts.Data.Models
{
    public partial class FrameData : Resource
    {
        [Export]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [Export]
        [JsonPropertyName("license_level")]
        public int LicenseLevel { get; set; } = 0;

        [Export]
        [JsonPropertyName("license_id")]
        public string LicenseId { get; set; }

        [Export]
        [JsonPropertyName("variant")]
        public string Variant { get; set; }

        [Export]
        [JsonPropertyName("source")]
        public string Source { get; set; }

        [Export]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [Export]
        [JsonPropertyName("mechtype")]
        public string[] MechType { get; set; }

        [Export]
        [JsonPropertyName("specialty")]
        public bool SpecialtyBool { get; set; }

        [Export]
        [JsonPropertyName("specialty")]
        public SpecialtyPrerequisite SpecialtyPrereq { get; set; }

        [Export]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [Export]
        [JsonPropertyName("mounts")]
        [JsonConverter(typeof(JsonEnumListConverter<MountType>))]
        public Godot.Collections.Array<MountType> Mounts { get; set; }

        [Export]
        [JsonPropertyName("stats")]
        public FrameStats Stats { get; set; }

        [Export]
        [JsonPropertyName("traits")]
        public FrameTraitData[] Traits { get; set; }

        [Export]
        [JsonPropertyName("core_system")]
        public CoreSystemData CoreSystem { get; set; }

        [Export]
        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }

        [Export]
        [JsonPropertyName("y_pos")]
        public float YPos { get; set; }
    }

    public partial class FrameStats : Resource
    {
        [Export]
        [JsonPropertyName("size")]
        public float Size { get; set; }

        [Export]
        [JsonPropertyName("structure")]
        public int Structure { get; set; }

        [Export]
        [JsonPropertyName("stress")]
        public int Stress { get; set; }

        [Export]
        [JsonPropertyName("armor")]
        public int Armor { get; set; }

        [Export]
        [JsonPropertyName("hp")]
        public int HP { get; set; }

        [Export]
        [JsonPropertyName("evasion")]
        public int Evasion { get; set; }

        [Export]
        [JsonPropertyName("edef")]
        public int EDef { get; set; }

        [Export]
        [JsonPropertyName("heatcap")]
        public int HeatCap { get; set; }

        [Export]
        [JsonPropertyName("repcap")]
        public int RepCap { get; set; }

        [Export]
        [JsonPropertyName("sensor_range")]
        public int SensorRange { get; set; }

        [Export]
        [JsonPropertyName("tech_attack")]
        public int TechAttack { get; set; }

        [Export]
        [JsonPropertyName("save")]
        public int Save { get; set; }

        [Export]
        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [Export]
        [JsonPropertyName("sp")]
        public int SP { get; set; }
    }

    [JsonConverter(typeof(JsonEnumMemberStringEnumConverter<MountType>))]
    public enum MountType
    {
        Main,
        Heavy,
        [JsonPropertyName("Aux/Aux")]
        AuxAux,
        Auxiliary,
        [JsonPropertyName("Main/Aux")]
        MainAux,
        Flex,
        Integrated,
        Superheavy,
        Special,
        [JsonPropertyName("Ship-class")]
        ShipClass

    }

    public partial class SpecialtyPrerequisite : Resource
    {
        [Export]
        [JsonPropertyName("source")]
        public string Source { get; set; }

        [Export]
        [JsonPropertyName("min_rank")]
        public int MinRank { get; set; }

        [Export]
        [JsonPropertyName("cumulative")]
        public bool Cumulative { get; set; }
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
