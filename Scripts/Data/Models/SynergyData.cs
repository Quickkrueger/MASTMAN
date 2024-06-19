using MASTMAN.Util;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MASTMAN.Scripts.Data.Models
{
    public class SynergyData
    {
        [JsonPropertyName("locations")]
        public List<string> Locations { get; set; }

        [JsonPropertyName("detail")]
        public string Detail { get; set; }

        [JsonPropertyName("weapon_types")]
        [JsonConverter(typeof(JsonEnumListConverter<WeaponType>))]
        public List<WeaponType> WeaponTypes { get; set; }

        [JsonPropertyName("system_types")]
        [JsonConverter(typeof(JsonEnumListConverter<SystemType>))]
        public List<SystemType> SystemTypes { get; set; }

        [JsonPropertyName("weapon_sizes")]
        [JsonConverter(typeof(JsonEnumListConverter<WeaponSize>))]
        public List<WeaponSize> WeaponSizes { get; set; }
    }
}
