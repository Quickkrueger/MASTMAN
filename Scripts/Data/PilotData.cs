using Godot;

namespace MASTMAN.Data
{
    public partial class PilotData : Resource
    {
        public string id { get; set; }
        public int level { get; set; }
        public string callsign { get; set; }
        public string name { get; set; }
        public string player_name { get; set; }
        public string status { get; set; }
        public bool dead { get; set; }
        public string text_appearance { get; set; }
        public string notes { get; set; }
        public string history { get; set; }
        public object[] quirks { get; set; }
        public int current_hp { get; set; }
        public string background { get; set; }
        public object[] resistances { get; set; }
        public Mech[] mechs { get; set; }
        public string cc_ver { get; set; }
        public Special_Equipment special_equipment { get; set; }
        public Combat_History combat_history { get; set; }
        public State state { get; set; }
        public string lastModified { get; set; }
        public bool isDeleted { get; set; }
        public string expireTime { get; set; }
        public string deleteTime { get; set; }
        public string lastUpdate_cloud { get; set; }
        public string lastSync { get; set; }
        public string shareCode { get; set; }
        public string shareCodeExpiry { get; set; }
        public Skill[] skills { get; set; }
        public Talent[] talents { get; set; }
        public int[] mechSkills { get; set; }
        public object[] counter_data { get; set; }
        public object[] custom_counters { get; set; }
        public object[] core_bonuses { get; set; }
        public License[] licenses { get; set; }
        public object[] reserves { get; set; }
        public object[] orgs { get; set; }
        public string bondId { get; set; }
        public int xp { get; set; }
        public int stress { get; set; }
        public bool isBroken { get; set; }
        public object[] burdens { get; set; }
        public Bondpower[] bondPowers { get; set; }
        public int powerSelections { get; set; }
        public int maxStress { get; set; }
        public string[] bondAnswers { get; set; }
        public string minorIdeal { get; set; }
        public object[] clocks { get; set; }
        public string group { get; set; }
        public int sort_index { get; set; }
        public string portrait { get; set; }
        public string cloud_portrait { get; set; }
        public Loadout loadout { get; set; }
        public object[] brews { get; set; }
    }

    public class Special_Equipment
    {
        public object[] PilotGear { get; set; }
        public object[] Frames { get; set; }
        public object[] MechWeapons { get; set; }
        public object[] WeaponMods { get; set; }
        public object[] MechSystems { get; set; }
        public object[] SystemMods { get; set; }
    }

    public class Combat_History
    {
        public int moves { get; set; }
        public int kills { get; set; }
        public int damage { get; set; }
        public int hp_damage { get; set; }
        public int structure_damage { get; set; }
        public int overshield { get; set; }
        public int heat_damage { get; set; }
        public int reactor_damage { get; set; }
        public int overcharge_uses { get; set; }
        public int core_uses { get; set; }
    }

    public class State
    {
        public string active_mech_id { get; set; }
        public string remote_mech_id { get; set; }
        public string stage { get; set; }
        public int turn { get; set; }
        public int mission { get; set; }
        public int actions { get; set; }
        public bool braced { get; set; }
        public bool overcharged { get; set; }
        public bool prepare { get; set; }
        public bool bracedCooldown { get; set; }
        public bool redundant { get; set; }
        public bool mounted { get; set; }
        public Stats stats { get; set; }
        public object[] deployed { get; set; }
    }

    public class Stats
    {
        public int moves { get; set; }
        public int kills { get; set; }
        public int damage { get; set; }
        public int hp_damage { get; set; }
        public int structure_damage { get; set; }
        public int overshield { get; set; }
        public int heat_damage { get; set; }
        public int reactor_damage { get; set; }
        public int overcharge_uses { get; set; }
        public int core_uses { get; set; }
    }

    public class Loadout
    {
        public string id { get; set; }
        public string name { get; set; }
        public Armor[] armor { get; set; }
        public Weapon[] weapons { get; set; }
        public Gear[] gear { get; set; }
        public object[] extendedWeapons { get; set; }
        public object[] extendedGear { get; set; }
    }

    public class Armor
    {
        public string id { get; set; }
        public bool destroyed { get; set; }
        public int uses { get; set; }
        public bool cascading { get; set; }
        public string flavorName { get; set; }
        public string flavorDescription { get; set; }
        public object customDamageType { get; set; }
    }

    public class Weapon
    {
        public string id { get; set; }
        public bool destroyed { get; set; }
        public int uses { get; set; }
        public bool cascading { get; set; }
        public string flavorName { get; set; }
        public string flavorDescription { get; set; }
        public object customDamageType { get; set; }
    }

    public class Gear
    {
        public string id { get; set; }
        public bool destroyed { get; set; }
        public int uses { get; set; }
        public bool cascading { get; set; }
        public string flavorName { get; set; }
        public string flavorDescription { get; set; }
        public object customDamageType { get; set; }
        public string note { get; set; }
    }

    public class Mech
    {
        public string id { get; set; }
        public string name { get; set; }
        public string notes { get; set; }
        public string gm_note { get; set; }
        public string frame { get; set; }
        public bool active { get; set; }
        public int current_structure { get; set; }
        public int current_move { get; set; }
        public int boost { get; set; }
        public int current_hp { get; set; }
        public int overshield { get; set; }
        public int current_stress { get; set; }
        public int current_heat { get; set; }
        public int current_repairs { get; set; }
        public int current_overcharge { get; set; }
        public int current_core_energy { get; set; }
        public object[] statuses { get; set; }
        public object[] conditions { get; set; }
        public object[] resistances { get; set; }
        public object[] reactions { get; set; }
        public int burn { get; set; }
        public bool destroyed { get; set; }
        public string defeat { get; set; }
        public int activations { get; set; }
        public bool meltdown_imminent { get; set; }
        public bool reactor_destroyed { get; set; }
        public bool core_active { get; set; }
        public string cc_ver { get; set; }
        public string lastModified { get; set; }
        public bool isDeleted { get; set; }
        public string expireTime { get; set; }
        public string deleteTime { get; set; }
        public string portrait { get; set; }
        public string cloud_portrait { get; set; }
        public MechLoadout[] loadouts { get; set; }
        public int active_loadout_index { get; set; }
    }

    public class MechLoadout
    {
        public string id { get; set; }
        public string name { get; set; }
        public System[] systems { get; set; }
        public object[] integratedSystems { get; set; }
        public Mount[] mounts { get; set; }
        public object[] integratedMounts { get; set; }
        public Improved_Armament improved_armament { get; set; }
        public Superheavy_Mounting superheavy_mounting { get; set; }
        public Integratedweapon integratedWeapon { get; set; }
        public object[] extraMounts { get; set; }
        public object[] extraIntegratedMounts { get; set; }
    }

    public class Improved_Armament
    {
        public string mount_type { get; set; }
        public bool _lock { get; set; }
        public Slot[] slots { get; set; }
        public Extra[] extra { get; set; }
        public object[] bonus_effects { get; set; }
        public bool modifiable { get; set; }
    }

    public class Slot
    {
        public string size { get; set; }
        public object weapon { get; set; }
    }

    public class Extra
    {
        public string size { get; set; }
        public object weapon { get; set; }
    }

    public class Superheavy_Mounting
    {
        public string mount_type { get; set; }
        public bool _lock { get; set; }
        public Slot1[] slots { get; set; }
        public object[] extra { get; set; }
        public object[] bonus_effects { get; set; }
        public bool modifiable { get; set; }
    }

    public class Slot1
    {
        public string size { get; set; }
        public object weapon { get; set; }
    }

    public class Integratedweapon
    {
        public string mount_type { get; set; }
        public bool _lock { get; set; }
        public Slot2[] slots { get; set; }
        public object[] extra { get; set; }
        public object[] bonus_effects { get; set; }
        public bool modifiable { get; set; }
    }

    public class Slot2
    {
        public string size { get; set; }
        public object weapon { get; set; }
    }

    public class System
    {
        public string id { get; set; }
        public int uses { get; set; }
        public bool destroyed { get; set; }
        public bool cascading { get; set; }
        public string flavorName { get; set; }
        public string flavorDescription { get; set; }
    }

    public class Mount
    {
        public string mount_type { get; set; }
        public bool _lock { get; set; }
        public Slot3[] slots { get; set; }
        public Extra1[] extra { get; set; }
        public object[] bonus_effects { get; set; }
        public bool modifiable { get; set; }
    }

    public class Slot3
    {
        public string size { get; set; }
        public Weapon1 weapon { get; set; }
    }

    public class Weapon1
    {
        public string id { get; set; }
        public bool destroyed { get; set; }
        public bool cascading { get; set; }
        public bool loaded { get; set; }
        public object mod { get; set; }
        public string flavorName { get; set; }
        public string flavorDescription { get; set; }
        public object customDamageType { get; set; }
        public int maxUseOverride { get; set; }
        public int uses { get; set; }
        public int selectedProfile { get; set; }
    }

    public class Extra1
    {
        public string size { get; set; }
        public object weapon { get; set; }
    }

    public class Skill
    {
        public string id { get; set; }
        public int rank { get; set; }
    }

    public class Talent
    {
        public string id { get; set; }
        public int rank { get; set; }
    }

    public class License
    {
        public string id { get; set; }
        public int rank { get; set; }
    }

    public class Bondpower
    {
        public string name { get; set; }
        public string description { get; set; }
    }

}