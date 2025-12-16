using MASTMAN.Util;
using System.Collections.Generic;
using Godot;
using System.Text.Json.Serialization;

namespace MASTMAN.Scripts.Data.Models
{
    public partial class SystemData : Resource
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
        [JsonPropertyName("effect")]
        public string Effect { get; set; }

        [Export]
        [JsonPropertyName("type")]
        public SystemType Type { get; set; }

        [Export]
        [JsonPropertyName("sp")]
        public int Sp { get; set; }

        [Export]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [Export]
        [JsonPropertyName("tags")]
        public TagValData[] Tags { get; set; }

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
