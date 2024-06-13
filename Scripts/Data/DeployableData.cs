using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MASTMAN.Data
{
    public class DeployableData
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; } // This is for UI furnishing only

        [JsonPropertyName("detail")]
        public string Detail { get; set; }

        [JsonPropertyName("size")]
        public float Size { get; set; } // Not required for Mines

        [JsonPropertyName("activation")]
        public ActivationType? Activation { get; set; }

        [JsonPropertyName("deactivation")]
        public ActivationType? Deactivation { get; set; }

        [JsonPropertyName("recall")]
        public ActivationType? Recall { get; set; }

        [JsonPropertyName("redeploy")]
        public ActivationType? Redeploy { get; set; }

        [JsonPropertyName("instances")]
        public int? Instances { get; set; }

        [JsonPropertyName("cost")]
        public int? Cost { get; set; }

        [JsonPropertyName("armor")]
        public int? Armor { get; set; }

        [JsonPropertyName("hp")]
        [JsonConverter(typeof(StringOrIntToStringConverter))]
        public string? Hp { get; set; }

        [JsonPropertyName("evasion")]
        public int? Evasion { get; set; }

        [JsonPropertyName("edef")]
        public int? Edef { get; set; }

        [JsonPropertyName("heatcap")]
        public int? Heatcap { get; set; }

        [JsonPropertyName("repcap")]
        public int? Repcap { get; set; }

        [JsonPropertyName("sensor_range")]
        public int? SensorRange { get; set; }

        [JsonPropertyName("tech_attack")]
        public int? TechAttack { get; set; }

        [JsonPropertyName("save")]
        public int? Save { get; set; }

        [JsonPropertyName("speed")]
        public int? Speed { get; set; }

        [JsonPropertyName("pilot")]
        public bool? Pilot { get; set; }

        [JsonPropertyName("mech")]
        public bool? Mech { get; set; }

        [JsonPropertyName("actions")]
        public List<ItemActionData> Actions { get; set; }

        [JsonPropertyName("bonuses")]
        public List<BonusData> Bonuses { get; set; }

        [JsonPropertyName("synergies")]
        public List<SynergyData> Synergies { get; set; }

        [JsonPropertyName("counters")]
        public List<CounterData> Counters { get; set; }

        [JsonPropertyName("tags")]
        public List<TagValData> Tags { get; set; }
    }

    public class DeployedData
    {
        [JsonPropertyName("data")]
        public DeployableData Data { get; set; }

        [JsonPropertyName("assigned_name")]
        public string AssignedName { get; set; }

        [JsonPropertyName("current_hp")]
        public int CurrentHp { get; set; }

        [JsonPropertyName("current_duration")]
        public int? CurrentDuration { get; set; }

        [JsonPropertyName("overshield")]
        public int? Overshield { get; set; }

        [JsonPropertyName("destroyed")]
        public bool? Destroyed { get; set; }
    }
}
