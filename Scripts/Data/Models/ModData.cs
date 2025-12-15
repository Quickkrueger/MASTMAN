using MASTMAN.Util;
using Godot;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MASTMAN.Scripts.Data.Models
{
    public partial class ModData : Resource
    {
        [Export]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [Export]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [Export]
        [JsonPropertyName("source")]
        public string Source { get; set; }

        [Export]
        [JsonPropertyName("license")]
        public string License { get; set; }

        [Export]
        [JsonPropertyName("license_id")]
        public string LicenseId { get; set; }

        [Export]
        [JsonPropertyName("license_level")]
        public int LicenseLevel { get; set; }

        [Export]
        [JsonPropertyName("sp")]
        public int Sp { get; set; }
        [Export]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [Export]
        [JsonPropertyName("effect")]
        public string Effect { get; set; }

        [Export]
        [JsonPropertyName("tags")]
        public TagValData[] Tags { get; set; }

        [Export]
        [JsonPropertyName("allowed_types")]
        [JsonConverter(typeof(JsonEnumListConverter<WeaponType>))]
        public Godot.Collections.Array<WeaponType> AllowedTypes { get; set; }

        [Export]
        [JsonPropertyName("allowed_sizes")]
        [JsonConverter(typeof(JsonEnumListConverter<WeaponSize>))]
        public Godot.Collections.Array<WeaponSize> AllowedSizes { get; set; }

        [Export]
        [JsonPropertyName("restricted_types")]
        [JsonConverter(typeof(JsonEnumListConverter<WeaponType>))]
        public Godot.Collections.Array<WeaponType> RestrictedTypes { get; set; }

        [Export]
        [JsonPropertyName("restricted_sizes")]
        [JsonConverter(typeof(JsonEnumListConverter<WeaponSize>))]
        public Godot.Collections.Array<WeaponSize> RestrictedSizes { get; set; }

        [Export]
        [JsonPropertyName("added_tags")]
        public TagValData[] AddedTags { get; set; }

        [Export]
        [JsonPropertyName("added_damage")]
        public DamageData[] AddedDamage { get; set; }

        [Export]
        [JsonPropertyName("added_range")]
        public RangeData[] AddedRange { get; set; }

        [Export]
        [JsonPropertyName("actions")]
        public ItemActionData[] Actions { get; set; }

        [Export]
        [JsonPropertyName("bonuses")]
        public BonusData[] Bonuses { get; set; }

        [Export]
        [JsonPropertyName("synergies")]
        public SynergyData[] Synergies { get; set; }

        [Export]
        [JsonPropertyName("deployables")]
        public DeployableData[] Deployables { get; set; }

        [Export]
        [JsonPropertyName("counters")]
        public CounterData[] Counters { get; set; }

        [Export]
        [JsonPropertyName("integrated")]
        public string[] Integrated { get; set; }

        [Export]
        [JsonPropertyName("special_equipment")]
        public string[] SpecialEquipment { get; set; }
    }

    public partial class DamageData : Resource
    {
        [Export]
        [JsonPropertyName("type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DamageType Type { get; set; }

        [Export]
        [JsonPropertyName("val")]
        [JsonConverter(typeof(StringOrIntToStringConverter))]
        public string Val { get; set; }
    }

    public partial class RangeData : Resource
    {
        [Export]
        [JsonPropertyName("type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public RangeType Type { get; set; }

        [Export]
        [JsonPropertyName("val")]
        [JsonConverter(typeof(StringOrIntToStringConverter))]
        public string Val { get; set; }
    }

    public class StringOrIntToStringConverter : JsonConverter<string>
    {
        public override string Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                return reader.GetString();
            }
            else if (reader.TokenType == JsonTokenType.Number)
            {
                return reader.GetInt32().ToString();
            }
            throw new JsonException($"Unexpected token type: {reader.TokenType}");
        }

        public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value);
        }
    }


}
