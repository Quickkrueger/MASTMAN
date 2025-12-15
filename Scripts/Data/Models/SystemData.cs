using MASTMAN.Util;
using System.Collections.Generic;
using Godot;
using System.Text.Json.Serialization;

namespace MASTMAN.Scripts.Data.Models
{
    public partial class SystemData : Resource
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

        [JsonPropertyName("effect")]
        public string Effect { get; set; }

        [JsonPropertyName("type")]
        public SystemType Type { get; set; }

        [JsonPropertyName("sp")]
        public int? Sp { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("tags")]
        public List<TagValData> Tags { get; set; }

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

    [JsonConverter(typeof(JsonEnumMemberStringEnumConverter<SystemType>))]
    public enum SystemType
    {
        AI,
        Deployable,
        Drone,
        [JsonPropertyName("Flight System")]
        FlightSystem,
        Shield,
        System,
        Tech
    }

}
