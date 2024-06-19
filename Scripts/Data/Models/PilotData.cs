using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MASTMAN.Scripts.Data.Models
{
    public class PilotData
    {
        [JsonPropertyName("minorIdeal")]
        public string MinorIdeal { get; set; }

        [JsonPropertyName("bondAnswers")]
        public List<string> BondAnswers { get; set; }

        [JsonPropertyName("maxStress")]
        public int MaxStress { get; set; }

        [JsonPropertyName("powerSelections")]
        public int PowerSelections { get; set; }

        [JsonPropertyName("bondId")]
        public string BondId { get; set; }

        [JsonPropertyName("xp")]
        public int Xp { get; set; }

        [JsonPropertyName("stress")]
        public int Stress { get; set; }

        [JsonPropertyName("isBroken")]
        public bool IsBroken { get; set; }

        [JsonPropertyName("burdens")]
        public List<ClockData> Burdens { get; set; }

        [JsonPropertyName("bondPowers")]
        public List<BondPower> BondPowers { get; set; }

        [JsonPropertyName("clocks")]
        public List<ClockData> Clocks { get; set; }

        [JsonPropertyName("pilotBond")]
        public PilotBondData PilotBond { get; set; }

        [JsonPropertyName("remoteIID")]
        public string RemoteIID { get; set; }

        [JsonPropertyName("remoteKey")]
        public string RemoteKey { get; set; }

        [JsonPropertyName("shareCodeExpiry")]
        public string ShareCodeExpiry { get; set; }

        [JsonPropertyName("shareCode")]
        public string ShareCode { get; set; }

        [JsonPropertyName("isRemoteResource")]
        public bool IsRemoteResource { get; set; }

        [JsonPropertyName("deleteTime")]
        public string DeleteTime { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("level")]
        public int Level { get; set; }

        [JsonPropertyName("callsign")]
        public string Callsign { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("player_name")]
        public string PlayerName { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("text_appearance")]
        public string TextAppearance { get; set; }

        [JsonPropertyName("notes")]
        public string Notes { get; set; }

        [JsonPropertyName("history")]
        public string History { get; set; }

        [JsonPropertyName("quirks")]
        public List<string> Quirks { get; set; }

        [JsonPropertyName("current_hp")]
        public int CurrentHp { get; set; }

        [JsonPropertyName("background")]
        public string Background { get; set; }

        [JsonPropertyName("resistances")]
        public List<string> Resistances { get; set; }

        [JsonPropertyName("special_equipment")]
        public UnlockData SpecialEquipment { get; set; }

        [JsonPropertyName("mechs")]
        public List<MechData> Mechs { get; set; }

        [JsonPropertyName("cc_ver")]
        public string CcVer { get; set; }

        [JsonPropertyName("brews")]
        public List<BrewInfo> Brews { get; set; }

        [JsonPropertyName("state")]
        public ActiveStateData State { get; set; }

        [JsonPropertyName("combat_history")]
        public CombatStats CombatHistory { get; set; }

        [JsonPropertyName("dead")]
        public bool Dead { get; set; }

        // SaveController
        [JsonPropertyName("lastModified")]
        public string LastModified { get; set; }

        [JsonPropertyName("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonPropertyName("expireTime")]
        public string ExpireTime { get; set; }

        // PortraitController
        [JsonPropertyName("portrait")]
        public string Portrait { get; set; }

        [JsonPropertyName("cloud_portrait")]
        public string CloudPortrait { get; set; }

        // CloudController
        [JsonPropertyName("lastUpdate_cloud")]
        public string LastUpdateCloud { get; set; }

        [JsonPropertyName("resourceUri")]
        public string ResourceUri { get; set; }

        [JsonPropertyName("lastSync")]
        public string LastSync { get; set; }

        // SkillsController
        [JsonPropertyName("skills")]
        public List<RankedData> Skills { get; set; }

        // TalentsController
        [JsonPropertyName("talents")]
        public List<RankedData> Talents { get; set; }

        // MechSkillsController
        [JsonPropertyName("mechSkills")]
        public List<int> MechSkills { get; set; }

        // CounterController
        [JsonPropertyName("custom_counters")]
        public List<object> CustomCounters { get; set; }

        [JsonPropertyName("counter_data")]
        public List<CounterSaveData> CounterData { get; set; }

        // CoreBonusController
        [JsonPropertyName("core_bonuses")]
        public List<string> CoreBonuses { get; set; }

        // LicenseController
        [JsonPropertyName("licenses")]
        public List<RankedData> Licenses { get; set; }

        // ReservesController
        [JsonPropertyName("reserves")]
        public List<ReserveData> Reserves { get; set; }

        [JsonPropertyName("orgs")]
        public List<OrganizationData> Orgs { get; set; }

        // GroupController
        [JsonPropertyName("group")]
        public string Group { get; set; }

        [JsonPropertyName("sort_index")]
        public int SortIndex { get; set; }

        // PilotLoadoutController
        [JsonPropertyName("loadout")]
        public PilotLoadoutData Loadout { get; set; }
    }

    public class PilotLoadoutData
    {
        [JsonPropertyName("armor")]
        public List<PilotGearData> Armor { get; set; }

        [JsonPropertyName("gear")]
        public List<PilotGearData> Gear { get; set; }

        [JsonPropertyName("weapons")]
        public List<PilotGearData> Weapons { get; set; }

        [JsonPropertyName("extendedWeapons")]
        public List<PilotGearData> ExtendedWeapons { get; set; }

        [JsonPropertyName("extendedGear")]
        public List<PilotGearData> ExtendedGear { get; set; }
    }

    public class CombatStats
    {
        [JsonPropertyName("moves")]
        public int Moves { get; set; }

        [JsonPropertyName("kills")]
        public int Kills { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("hp_damage")]
        public int HpDamage { get; set; }

        [JsonPropertyName("structure_damage")]
        public int StructureDamage { get; set; }

        [JsonPropertyName("overshield")]
        public int Overshield { get; set; }

        [JsonPropertyName("heat_damage")]
        public int HeatDamage { get; set; }

        [JsonPropertyName("reactor_damage")]
        public int ReactorDamage { get; set; }

        [JsonPropertyName("overcharge_uses")]
        public int OverchargeUses { get; set; }

        [JsonPropertyName("core_uses")]
        public int CoreUses { get; set; }
    }

    public class OrganizationData
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("purpose")]
        public string Purpose { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("efficiency")]
        public int Efficiency { get; set; }

        [JsonPropertyName("influence")]
        public int Influence { get; set; }

        [JsonPropertyName("actions")]
        public string Actions { get; set; }
    }

    public class UnlockData
    {
        [JsonPropertyName("pilotGear")]
        public List<string> PilotGear { get; set; }

        [JsonPropertyName("frames")]
        public List<string> Frames { get; set; }

        [JsonPropertyName("mechWeapons")]
        public List<string> MechWeapons { get; set; }

        [JsonPropertyName("weaponMods")]
        public List<string> WeaponMods { get; set; }

        [JsonPropertyName("mechSystems")]
        public List<string> MechSystems { get; set; }

        [JsonPropertyName("systemMods")]
        public List<string> SystemMods { get; set; }
    }

    public class ClockData
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("resolution")]
        public string Resolution { get; set; }

        [JsonPropertyName("segments")]
        public int Segments { get; set; }

        [JsonPropertyName("progress")]
        public int Progress { get; set; }

        [JsonPropertyName("linear")]
        public bool Linear { get; set; }
    }


    public class ActiveStateData
    {
        [JsonPropertyName("active_mech_id")]
        public string ActiveMechId { get; set; }

        [JsonPropertyName("remote_mech_id")]
        public string RemoteMechId { get; set; }

        [JsonPropertyName("stage")]
        public string Stage { get; set; }

        [JsonPropertyName("mission")]
        public int Mission { get; set; }

        [JsonPropertyName("turn")]
        public int Turn { get; set; }

        [JsonPropertyName("actions")]
        public int Actions { get; set; }

        [JsonPropertyName("braced")]
        public bool Braced { get; set; }

        [JsonPropertyName("overcharged")]
        public bool Overcharged { get; set; }

        [JsonPropertyName("prepare")]
        public bool Prepare { get; set; }

        [JsonPropertyName("bracedCooldown")]
        public bool BracedCooldown { get; set; }

        [JsonPropertyName("redundant")]
        public bool Redundant { get; set; }

        [JsonPropertyName("mounted")]
        public bool Mounted { get; set; }

        [JsonPropertyName("stats")]
        public CombatStats Stats { get; set; }

        [JsonPropertyName("deployed")]
        public DeployedData[] Deployed { get; set; }
    }

    public struct BrewInfo
    {
        [JsonPropertyName("LcpId")]
        public string LcpId { get; set; }

        [JsonPropertyName("LcpName")]
        public string LcpName { get; set; }

        [JsonPropertyName("LcpVersion")]
        public string LcpVersion { get; set; }

        [JsonPropertyName("Website")]
        public string Website { get; set; }
    }
}
