using MASTMAN.Util;
using Godot;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MASTMAN.Scripts.Data.Models
{
    public partial class WeaponData : Resource
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
        [JsonPropertyName("mount")]
        public MountType Mount { get; set; }

        [Export]
        [JsonPropertyName("type")]
        public WeaponType Type { get; set; }

        [Export]
        [JsonPropertyName("cost")]
        public int Cost { get; set; }

        [Export]
        [JsonPropertyName("barrage")]
        public bool Barrage { get; set; }

        [Export]
        [JsonPropertyName("skirmish")]
        public bool Skirmish { get; set; }

        [Export]
        [JsonPropertyName("no_attack")]
        public bool NoAttack { get; set; }

        [Export]
        [JsonPropertyName("no_mods")]
        public bool NoMods { get; set; }

        [Export]
        [JsonPropertyName("no_core_bonus")]
        public bool NoCoreBonus { get; set; }

        [Export]
        [JsonPropertyName("damage")]
        public DamageData[] Damage { get; set; }

        [Export]
        [JsonPropertyName("range")]
        public RangeData[] Range { get; set; }

        [Export]
        [JsonPropertyName("tags")]
        public TagValData[] Tags { get; set; }

        [Export]
        [JsonPropertyName("sp")]
        public int SP { get; set; }

        [Export]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [Export]
        [JsonPropertyName("effect")]
        public string Effect { get; set; }

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
        [JsonPropertyName("actions")]
        public ItemActionData[] Actions { get; set; }

        [Export]
        [JsonPropertyName("bonuses")]
        public BonusData[] Bonuses { get; set; }

        [Export]
        [JsonPropertyName("no_bonus")]
        public bool NoBonus { get; set; }

        [Export]
        [JsonPropertyName("synergies")]
        public SynergyData[] Synergies { get; set; }

        [Export]
        [JsonPropertyName("no_synergy")]
        public bool NoSynergy { get; set; }

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

        [Export]
        [JsonPropertyName("profiles")]
        public WeaponProfileData[] Profiles { get; set; }
    }

    [JsonConverter(typeof(JsonEnumMemberStringEnumConverter<WeaponType>))]
    public enum WeaponType
    {
        any,
        Rifle,
        Cannon,
        Launcher,
        CQB,
        Nexus,
        Melee,
        Special,
        [JsonPropertyName("Spool Weapon")]
        SpoolWeapon,
        [JsonPropertyName("???")]
        None
        // Add other weapon types as needed
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WeaponSize
    {
        any,
        Auxiliary,
        Main,
        Heavy,
        Superheavy
        // Add other weapon sizes as needed
    }
}
