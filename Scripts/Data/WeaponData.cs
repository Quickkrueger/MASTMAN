using MASTMAN.Util;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace MASTMAN.Data
{
    public class WeaponData
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

        [JsonPropertyName("mount")]
        public MountType Mount { get; set; }

        [JsonPropertyName("type")]
        public WeaponType Type { get; set; }

        [JsonPropertyName("cost")]
        public int Cost { get; set; }

        [JsonPropertyName("barrage")]
        public bool Barrage { get; set; }

        [JsonPropertyName("skirmish")]
        public bool Skirmish { get; set; }

        [JsonPropertyName("no_attack")]
        public bool NoAttack { get; set; }

        [JsonPropertyName("no_mods")]
        public bool NoMods { get; set; }

        [JsonPropertyName("no_core_bonus")]
        public bool NoCoreBonus { get; set; }

        [JsonPropertyName("damage")]
        public List<DamageData> Damage { get; set; }

        [JsonPropertyName("range")]
        public List<RangeData> Range { get; set; }

        [JsonPropertyName("tags")]
        public List<TagValData> Tags { get; set; }

        [JsonPropertyName("sp")]
        public int SP { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("effect")]
        public string Effect { get; set; }

        [JsonPropertyName("on_attack")]
        public string OnAttack { get; set; }

        [JsonPropertyName("on_hit")]
        public string OnHit { get; set; }

        [JsonPropertyName("on_crit")]
        public string OnCrit { get; set; }

        [JsonPropertyName("actions")]
        public List<ItemActionData> Actions { get; set; }

        [JsonPropertyName("bonuses")]
        public List<BonusData> Bonuses { get; set; }

        [JsonPropertyName("no_bonus")]
        public bool NoBonus { get; set; }

        [JsonPropertyName("synergies")]
        public List<SynergyData> Synergies { get; set; }

        [JsonPropertyName("no_synergy")]
        public bool NoSynergy { get; set; }

        [JsonPropertyName("deployables")]
        public List<DeployableData> Deployables { get; set; }

        [JsonPropertyName("counters")]
        public List<CounterData> Counters { get; set; }

        [JsonPropertyName("integrated")]
        public List<string> Integrated { get; set; }

        [JsonPropertyName("special_equipment")]
        public List<string> SpecialEquipment { get; set; }

        [JsonPropertyName("profiles")]
        public List<WeaponProfileData> Profiles { get; set; }
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
