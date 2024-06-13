using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections;

namespace MASTMAN.Util
{

    public class JsonEnumMemberStringEnumConverter<TEnum> : JsonConverter<TEnum> where TEnum : struct, Enum
    {
        private readonly Dictionary<string, TEnum> _nameToEnum;
        private readonly Dictionary<TEnum, string> _enumToName;

        public JsonEnumMemberStringEnumConverter()
        {
            _nameToEnum = new Dictionary<string, TEnum>();
            _enumToName = new Dictionary<TEnum, string>();

            foreach (var field in typeof(TEnum).GetFields(BindingFlags.Public | BindingFlags.Static))
            {
                var enumValue = (TEnum)field.GetValue(null);
                var jsonPropertyName = field.GetCustomAttribute<JsonPropertyNameAttribute>()?.Name ?? field.Name;
                _nameToEnum[jsonPropertyName] = enumValue;
                _enumToName[enumValue] = jsonPropertyName;
            }
        }

        public override TEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.String)
            {
                throw new JsonException();
            }

            var enumString = reader.GetString();
            if (_nameToEnum.TryGetValue(enumString, out var enumValue))
            {
                return enumValue;
            }

            throw new JsonException($"Unable to convert \"{enumString}\" to Enum \"{typeof(TEnum)}\"");
        }

        public override void Write(Utf8JsonWriter writer, TEnum value, JsonSerializerOptions options)
        {
            if (_enumToName.TryGetValue(value, out var name))
            {
                writer.WriteStringValue(name);
            }
            else
            {
                throw new JsonException($"Unable to convert Enum \"{typeof(TEnum)}\" to string.");
            }
        }
    }

    public class JsonEnumListConverter<TEnum> : JsonConverter<List<TEnum>> where TEnum : struct, Enum
    {
        private readonly JsonEnumMemberStringEnumConverter<TEnum> _enumConverter = new JsonEnumMemberStringEnumConverter<TEnum>();

        public override List<TEnum> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartArray)
            {
                throw new JsonException();
            }

            var list = new List<TEnum>();
            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndArray)
                {
                    break;
                }

                if (reader.TokenType == JsonTokenType.String)
                {
                    var enumValue = _enumConverter.Read(ref reader, typeof(TEnum), options);
                    list.Add(enumValue);
                }
                else
                {
                    throw new JsonException();
                }
            }

            return list;
        }

        public override void Write(Utf8JsonWriter writer, List<TEnum> value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            foreach (var enumValue in value)
            {
                _enumConverter.Write(writer, enumValue, options);
            }
            writer.WriteEndArray();
        }
    }
}
