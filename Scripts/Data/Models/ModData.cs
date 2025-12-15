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
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("license")]
        public string License { get; set; }

        [JsonPropertyName("license_id")]
        public string LicenseId { get; set; }

        [JsonPropertyName("license_level")]
        public int LicenseLevel { get; set; }

        [JsonPropertyName("sp")]
        public int? Sp { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("effect")]
        public string Effect { get; set; }

        [JsonPropertyName("tags")]
        public List<TagValData> Tags { get; set; }

        [JsonPropertyName("allowed_types")]
        [JsonConverter(typeof(JsonEnumListConverter<WeaponType>))]
        public List<WeaponType> AllowedTypes { get; set; }

        [JsonPropertyName("allowed_sizes")]
        [JsonConverter(typeof(JsonEnumListConverter<WeaponSize>))]
        public List<WeaponSize> AllowedSizes { get; set; }

        [JsonPropertyName("restricted_types")]
        [JsonConverter(typeof(JsonEnumListConverter<WeaponType>))]
        public List<WeaponType> RestrictedTypes { get; set; }

        [JsonPropertyName("restricted_sizes")]
        [JsonConverter(typeof(JsonEnumListConverter<WeaponSize>))]
        public List<WeaponSize> RestrictedSizes { get; set; }

        [JsonPropertyName("added_tags")]
        public List<TagValData> AddedTags { get; set; }

        [JsonPropertyName("added_damage")]
        public List<DamageData> AddedDamage { get; set; }

        [JsonPropertyName("added_range")]
        public List<RangeData> AddedRange { get; set; }

        [JsonPropertyName("actions")]
        public List<ItemActionData> Actions { get; set; }

        [JsonPropertyName("bonuses")]
        public List<BonusData> Bonuses { get; set; }

        [JsonPropertyName("synergies")]
        public List<SynergyData> Synergies { get; set; }

        [JsonPropertyName("deployables")]
        public List<DeployableData> Deployables { get; set; }

        [JsonPropertyName("counters")]
        public List<CounterData> Counters { get; set; }

        [JsonPropertyName("integrated")]
        public List<string> Integrated { get; set; }

        [JsonPropertyName("special_equipment")]
        public List<string> SpecialEquipment { get; set; }

    }

    public class DamageData
    {
        [JsonPropertyName("type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DamageType Type { get; set; }
        [JsonPropertyName("val")]
        [JsonConverter(typeof(StringOrIntToStringConverter))]
        public string Val { get; set; }
    }

    public class RangeData
    {
        [JsonPropertyName("type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public RangeType Type { get; set; }
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
