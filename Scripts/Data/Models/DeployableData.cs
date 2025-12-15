using Godot;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MASTMAN.Scripts.Data.Models
{
    public partial class DeployableData : Resource
    {
        [Export]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [Export]
        [JsonPropertyName("type")]
        public string Type { get; set; } // This is for UI furnishing only

        [Export]
        [JsonPropertyName("detail")]
        public string Detail { get; set; }

        [Export]
        [JsonPropertyName("size")]
        public float Size { get; set; } // Not required for Mines

        [Export]
        [JsonPropertyName("activation")]
        public ActivationType Activation { get; set; }

        [Export]
        [JsonPropertyName("deactivation")]
        public ActivationType Deactivation { get; set; }

        [Export]
        [JsonPropertyName("recall")]
        public ActivationType Recall { get; set; }

        [Export]
        [JsonPropertyName("redeploy")]
        public ActivationType Redeploy { get; set; }

        [Export]
        [JsonPropertyName("instances")]
        public int Instances { get; set; }

        [Export]
        [JsonPropertyName("cost")]
        public int Cost { get; set; }

        [Export]
        [JsonPropertyName("armor")]
        public int Armor { get; set; }

        [Export]
        [JsonPropertyName("hp")]
        [JsonConverter(typeof(StringOrIntToStringConverter))]
        public string Hp { get; set; }

        [Export]
        [JsonPropertyName("evasion")]
        public int Evasion { get; set; }

        [Export]
        [JsonPropertyName("edef")]
        public int Edef { get; set; }

        [Export]
        [JsonPropertyName("heatcap")]
        public int Heatcap { get; set; }

        [Export]
        [JsonPropertyName("repcap")]
        public int Repcap { get; set; }

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
        [JsonPropertyName("pilot")]
        public bool Pilot { get; set; }

        [Export]
        [JsonPropertyName("mech")]
        public bool Mech { get; set; }

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
        [JsonPropertyName("counters")]
        public CounterData[] Counters { get; set; }

        [Export]
        [JsonPropertyName("tags")]
        public TagValData[] Tags { get; set; }
    }

    public partial class DeployedData : Resource
    {
        [Export]
        [JsonPropertyName("data")]
        public DeployableData Data { get; set; }

        [Export]
        [JsonPropertyName("assigned_name")]
        public string AssignedName { get; set; }

        [Export]
        [JsonPropertyName("current_hp")]
        public int CurrentHp { get; set; }

        [Export]
        [JsonPropertyName("current_duration")]
        public int CurrentDuration { get; set; }

        [Export]
        [JsonPropertyName("overshield")]
        public int Overshield { get; set; }

        [Export]
        [JsonPropertyName("destroyed")]
        public bool Destroyed { get; set; }
    }
}
