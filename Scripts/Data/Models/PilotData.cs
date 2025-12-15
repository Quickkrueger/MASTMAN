using Godot;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MASTMAN.Scripts.Data.Models
{
    public partial class PilotData : Resource
    {
        [Export]
        [JsonPropertyName("minorIdeal")]
        public string MinorIdeal { get; set; }

        [Export]
        [JsonPropertyName("bondAnswers")]
        public string[] BondAnswers { get; set; }

        [Export]
        [JsonPropertyName("maxStress")]
        public int MaxStress { get; set; }

        [Export]
        [JsonPropertyName("powerSelections")]
        public int PowerSelections { get; set; }

        [Export]
        [JsonPropertyName("bondId")]
        public string BondId { get; set; }

        [Export]
        [JsonPropertyName("xp")]
        public int Xp { get; set; }

        [Export]
        [JsonPropertyName("stress")]
        public int Stress { get; set; }

        [Export]
        [JsonPropertyName("isBroken")]
        public bool IsBroken { get; set; }

        [Export]
        [JsonPropertyName("burdens")]
        public ClockData[] Burdens { get; set; }

        [Export]
        [JsonPropertyName("bondPowers")]
        public BondPower[] BondPowers { get; set; }

        [Export]
        [JsonPropertyName("clocks")]
        public ClockData[] Clocks { get; set; }

        [Export]
        [JsonPropertyName("pilotBond")]
        public PilotBondData PilotBond { get; set; }

        [Export]
        [JsonPropertyName("remoteIID")]
        public string RemoteIID { get; set; }

        [Export]
        [JsonPropertyName("remoteKey")]
        public string RemoteKey { get; set; }

        [Export]
        [JsonPropertyName("shareCodeExpiry")]
        public string ShareCodeExpiry { get; set; }

        [Export]
        [JsonPropertyName("shareCode")]
        public string ShareCode { get; set; }

        [Export]
        [JsonPropertyName("isRemoteResource")]
        public bool IsRemoteResource { get; set; }

        [Export]
        [JsonPropertyName("deleteTime")]
        public string DeleteTime { get; set; }

        [Export]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [Export]
        [JsonPropertyName("level")]
        public int Level { get; set; }

        [Export]
        [JsonPropertyName("callsign")]
        public string Callsign { get; set; }

        [Export]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [Export]
        [JsonPropertyName("player_name")]
        public string PlayerName { get; set; }

        [Export]
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [Export]
        [JsonPropertyName("text_appearance")]
        public string TextAppearance { get; set; }

        [Export]
        [JsonPropertyName("notes")]
        public string Notes { get; set; }

        [Export]
        [JsonPropertyName("history")]
        public string History { get; set; }

        [Export]
        [JsonPropertyName("quirks")]
        public string[] Quirks { get; set; }

        [Export]
        [JsonPropertyName("current_hp")]
        public int CurrentHp { get; set; }

        [Export]
        [JsonPropertyName("background")]
        public string Background { get; set; }

        [Export]
        [JsonPropertyName("resistances")]
        public string[] Resistances { get; set; }

        [Export]
        [JsonPropertyName("special_equipment")]
        public UnlockData SpecialEquipment { get; set; }

        [Export]
        [JsonPropertyName("mechs")]
        public MechData[] Mechs { get; set; }

        [Export]
        [JsonPropertyName("cc_ver")]
        public string CcVer { get; set; }

        [Export]
        [JsonPropertyName("brews")]
        public BrewInfo[] Brews { get; set; }

        [Export]
        [JsonPropertyName("state")]
        public ActiveStateData State { get; set; }

        [Export]
        [JsonPropertyName("combat_history")]
        public CombatStats CombatHistory { get; set; }

        [Export]
        [JsonPropertyName("dead")]
        public bool Dead { get; set; }

        [Export]
        // SaveController
        [JsonPropertyName("lastModified")]
        public string LastModified { get; set; }

        [Export]
        [JsonPropertyName("isDeleted")]
        public bool IsDeleted { get; set; }

        [Export]
        [JsonPropertyName("expireTime")]
        public string ExpireTime { get; set; }

        [Export]
        // PortraitController
        [JsonPropertyName("portrait")]
        public string Portrait { get; set; }

        [Export]
        [JsonPropertyName("cloud_portrait")]
        public string CloudPortrait { get; set; }

        [Export]
        // CloudController
        [JsonPropertyName("lastUpdate_cloud")]
        public string LastUpdateCloud { get; set; }

        [Export]
        [JsonPropertyName("resourceUri")]
        public string ResourceUri { get; set; }

        [Export]
        [JsonPropertyName("lastSync")]
        public string LastSync { get; set; }

        [Export]
        // SkillsController
        [JsonPropertyName("skills")]
        public RankedData[] Skills { get; set; }

        [Export]
        // TalentsController
        [JsonPropertyName("talents")]
        public RankedData[] Talents { get; set; }

        [Export]
        // MechSkillsController
        [JsonPropertyName("mechSkills")]
        public int[] MechSkills { get; set; }

        [Export]
        // CounterController
        [JsonPropertyName("custom_counters")]
        public CounterData[] CustomCounters { get; set; }

        [Export]
        [JsonPropertyName("counter_data")]
        public CounterSaveData[] CounterData { get; set; }

        [Export]
        // CoreBonusController
        [JsonPropertyName("core_bonuses")]
        public string[] CoreBonuses { get; set; }

        [Export]
        // LicenseController
        [JsonPropertyName("licenses")]
        public RankedData[] Licenses { get; set; }

        [Export]
        // ReservesController
        [JsonPropertyName("reserves")]
        public ReserveData[] Reserves { get; set; }

        [Export]
        [JsonPropertyName("orgs")]
        public OrganizationData[] Orgs { get; set; }

        [Export]
        // GroupController
        [JsonPropertyName("group")]
        public string Group { get; set; }

        [Export]
        [JsonPropertyName("sort_index")]
        public int SortIndex { get; set; }

        [Export]
        // PilotLoadoutController
        [JsonPropertyName("loadout")]
        public PilotLoadoutData Loadout { get; set; }
    }

    public partial class PilotLoadoutData : Resource
    {
        [Export]
        [JsonPropertyName("armor")]
        public PilotGearData[] Armor { get; set; }

        [Export]
        [JsonPropertyName("gear")]
        public PilotGearData[] Gear { get; set; }

        [Export]
        [JsonPropertyName("weapons")]
        public PilotGearData[] Weapons { get; set; }

        [Export]
        [JsonPropertyName("extendedWeapons")]
        public PilotGearData[] ExtendedWeapons { get; set; }

        [Export]
        [JsonPropertyName("extendedGear")]
        public PilotGearData[] ExtendedGear { get; set; }
    }

    public partial class CombatStats : Resource
    {
        [Export]
        [JsonPropertyName("moves")]
        public int Moves { get; set; }

        [Export]
        [JsonPropertyName("kills")]
        public int Kills { get; set; }

        [Export]
        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [Export]
        [JsonPropertyName("hp_damage")]
        public int HpDamage { get; set; }

        [Export]
        [JsonPropertyName("structure_damage")]
        public int StructureDamage { get; set; }

        [Export]
        [JsonPropertyName("overshield")]
        public int Overshield { get; set; }

        [Export]
        [JsonPropertyName("heat_damage")]
        public int HeatDamage { get; set; }

        [Export]
        [JsonPropertyName("reactor_damage")]
        public int ReactorDamage { get; set; }

        [Export]
        [JsonPropertyName("overcharge_uses")]
        public int OverchargeUses { get; set; }

        [Export]
        [JsonPropertyName("core_uses")]
        public int CoreUses { get; set; }
    }

    public partial class OrganizationData : Resource
    {
        [Export]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [Export]
        [JsonPropertyName("purpose")]
        public string Purpose { get; set; }

        [Export]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [Export]
        [JsonPropertyName("efficiency")]
        public int Efficiency { get; set; }

        [Export]
        [JsonPropertyName("influence")]
        public int Influence { get; set; }

        [Export]
        [JsonPropertyName("actions")]
        public string Actions { get; set; }
    }

    public partial class UnlockData : Resource
    {
        [Export]
        [JsonPropertyName("pilotGear")]
        public string[] PilotGear { get; set; }

        [Export]
        [JsonPropertyName("frames")]
        public string[] Frames { get; set; }

        [Export]
        [JsonPropertyName("mechWeapons")]
        public string[] MechWeapons { get; set; }

        [Export]
        [JsonPropertyName("weaponMods")]
        public string[] WeaponMods { get; set; }

        [Export]
        [JsonPropertyName("mechSystems")]
        public string[] MechSystems { get; set; }

        [Export]
        [JsonPropertyName("systemMods")]
        public string[] SystemMods { get; set; }
    }

    public partial class ClockData : Resource
    {
        [Export]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [Export]
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [Export]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [Export]
        [JsonPropertyName("resolution")]
        public string Resolution { get; set; }

        [Export]
        [JsonPropertyName("segments")]
        public int Segments { get; set; }

        [Export]
        [JsonPropertyName("progress")]
        public int Progress { get; set; }

        [Export]
        [JsonPropertyName("linear")]
        public bool Linear { get; set; }
    }


    public partial class ActiveStateData : Resource
    {
        [Export]
        [JsonPropertyName("active_mech_id")]
        public string ActiveMechId { get; set; }

        [Export]
        [JsonPropertyName("remote_mech_id")]
        public string RemoteMechId { get; set; }

        [Export]
        [JsonPropertyName("stage")]
        public string Stage { get; set; }

        [Export]
        [JsonPropertyName("mission")]
        public int Mission { get; set; }

        [Export]
        [JsonPropertyName("turn")]
        public int Turn { get; set; }

        [Export]
        [JsonPropertyName("actions")]
        public int Actions { get; set; }

        [Export]
        [JsonPropertyName("braced")]
        public bool Braced { get; set; }

        [Export]
        [JsonPropertyName("overcharged")]
        public bool Overcharged { get; set; }

        [Export]
        [JsonPropertyName("prepare")]
        public bool Prepare { get; set; }

        [Export]
        [JsonPropertyName("bracedCooldown")]
        public bool BracedCooldown { get; set; }

        [Export]
        [JsonPropertyName("redundant")]
        public bool Redundant { get; set; }

        [Export]
        [JsonPropertyName("mounted")]
        public bool Mounted { get; set; }

        [Export]
        [JsonPropertyName("stats")]
        public CombatStats Stats { get; set; }

        [Export]
        [JsonPropertyName("deployed")]
        public DeployedData[] Deployed { get; set; }
    }

    public partial class BrewInfo : Resource
    {
        [Export]
        [JsonPropertyName("LcpId")]
        public string LcpId { get; set; }

        [Export]
        [JsonPropertyName("LcpName")]
        public string LcpName { get; set; }

        [Export]
        [JsonPropertyName("LcpVersion")]
        public string LcpVersion { get; set; }

        [Export]
        [JsonPropertyName("Website")]
        public string Website { get; set; }
    }
}
