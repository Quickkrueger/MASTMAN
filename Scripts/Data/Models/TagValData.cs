using System.Text.Json.Serialization;
using System.Text.Json;
using System;

namespace MASTMAN.Scripts.Data.Models
{
    public class TagValData
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("val")]
        [JsonConverter(typeof(JsonStringOrNumberConverter))]
        public object Val { get; set; }
    }

    // Custom converter to handle both string and number types for the "val" property
    public class JsonStringOrNumberConverter : JsonConverter<object>
    {
        public override object Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                return reader.GetString();
            }
            else if (reader.TokenType == JsonTokenType.Number)
            {
                if (reader.TryGetInt64(out long l))
                {
                    return l;
                }

                return reader.GetDouble();
            }

            throw new JsonException("Unable to convert 'val' property");
        }

        public override void Write(Utf8JsonWriter writer, object value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case string s:
                    writer.WriteStringValue(s);
                    break;
                case long l:
                    writer.WriteNumberValue(l);
                    break;
                case double d:
                    writer.WriteNumberValue(d);
                    break;
                default:
                    throw new JsonException("Unsupported type for 'val' property");
            }
        }
    }
}
