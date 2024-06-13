using MASTMAN.Util;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MASTMAN.Data
{
    public class SynergyData
    {
        [JsonPropertyName("locations")]
        public List<string> Locations { get; set; }

        [JsonPropertyName("detail")]
        public string Detail { get; set; }

        [JsonPropertyName("weapon_types")]
        [JsonConverter(typeof(ItemConverterDecorator<JsonStringEnumConverter>))]
        public List<WeaponType> WeaponTypes { get; set; }

        [JsonPropertyName("system_types")]
        [JsonConverter(typeof(JsonEnumListConverter<SystemType>))]
        public List<SystemType> SystemTypes { get; set; }

        [JsonPropertyName("weapon_sizes")]
        [JsonConverter(typeof(ItemConverterDecorator<JsonStringEnumConverter>))]
        public List<WeaponSize> WeaponSizes { get; set; }
    }
}
