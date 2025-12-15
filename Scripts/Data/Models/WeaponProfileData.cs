using Godot;
using MASTMAN.Util;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MASTMAN.Scripts.Data.Models
{
    public partial class WeaponProfileData : Resource
    {
        [Export]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [Export]
        [JsonPropertyName("effect")]
        public string Effect { get; set; }

        [Export]
        [JsonPropertyName("skirmish")]
        public bool Skirmish { get; set; }

        [Export]
        [JsonPropertyName("barrage")]
        public bool Barrage { get; set; }

        [Export]
        [JsonPropertyName("cost")]
        public int Cost { get; set; }

        [Export]
        [JsonPropertyName("on_attack")]
        public string OnAttack { get; set; }

        [Export]
        [JsonPropertyName("on_hit")]
        public string OnHit { get; set; }

        [Export]
        [JsonPropertyName("on_crit")]
        public string OnCrit { get; set; }

        [Export]
        [JsonPropertyName("damage")]
        public DamageData[] Damage { get; set; }

        [Export]
        [JsonPropertyName("range")]
        public RangeData[] Range { get; set; }

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
}
