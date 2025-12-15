using Godot;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MASTMAN.Scripts.Data.Models
{
    public partial class MechData : Resource
    {
        [Export]
        [JsonPropertyName("deleteTime")]
        public string DeleteTime { get; set; }

        [Export]
        [JsonPropertyName("expireTime")]
        public string ExpireTime { get; set; }

        [Export]
        [JsonPropertyName("lastModified")]
        public string LastModified { get; set; }

        [Export]
        [JsonPropertyName("isDeleted")]
        public bool IsDeleted { get; set; }

        [Export]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [Export]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [Export]
        [JsonPropertyName("notes")]
        public string Notes { get; set; }

        [Export]
        [JsonPropertyName("gm_note")]
        public string GMNote { get; set; }

        [Export]
        [JsonPropertyName("portrait")]
        public string Portrait { get; set; }

        [Export]
        [JsonPropertyName("cloud_portrait")]
        public string CloudPortrait { get; set; }

        [Export]
        [JsonPropertyName("frame")]
        public string Frame { get; set; }

        [Export]
        [JsonPropertyName("active")]
        public bool Active { get; set; }

        [Export]
        [JsonPropertyName("current_structure")]
        public int CurrentStructure { get; set; }

        [Export]
        [JsonPropertyName("current_move")]
        public int CurrentMove { get; set; }

        [Export]
        [JsonPropertyName("boost")]
        public int Boost { get; set; }

        [Export]
        [JsonPropertyName("current_hp")]
        public int CurrentHp { get; set; }

        [Export]
        [JsonPropertyName("overshield")]
        public int Overshield { get; set; }

        [Export]
        [JsonPropertyName("current_stress")]
        public int CurrentStress { get; set; }

        [Export]
        [JsonPropertyName("current_heat")]
        public int CurrentHeat { get; set; }

        [Export]
        [JsonPropertyName("current_repairs")]
        public int CurrentRepairs { get; set; }

        [Export]
        [JsonPropertyName("current_overcharge")]
        public int CurrentOvercharge { get; set; }

        [Export]
        [JsonPropertyName("current_core_energy")]
        public int CurrentCoreEnergy { get; set; }

        [Export]
        [JsonPropertyName("loadouts")]
        public MechLoadoutData[] Loadouts { get; set; }

        [Export]
        [JsonPropertyName("active_loadout_index")]
        public int ActiveLoadoutIndex { get; set; }

        [Export]
        [JsonPropertyName("statuses")]
        public string[] Statuses { get; set; }

        [Export]
        [JsonPropertyName("conditions")]
        public string[] Conditions { get; set; }

        [Export]
        [JsonPropertyName("resistances")]
        public string[] Resistances { get; set; }

        [Export]
        [JsonPropertyName("reactions")]
        public string[] Reactions { get; set; }

        [Export]
        [JsonPropertyName("burn")]
        public int Burn { get; set; }

        [Export]
        [JsonPropertyName("destroyed")]
        public bool Destroyed { get; set; }

        [Export]
        [JsonPropertyName("defeat")]
        public string Defeat { get; set; }

        [Export]
        [JsonPropertyName("activations")]
        public int Activations { get; set; }

        [Export]
        [JsonPropertyName("meltdown_imminent")]
        public bool MeltdownImminent { get; set; }

        [Export]
        [JsonPropertyName("reactor_destroyed")]
        public bool ReactorDestroyed { get; set; }

        [Export]
        [JsonPropertyName("core_active")]
        public bool CoreActive { get; set; }

        [Export]
        [JsonPropertyName("cc_ver")]
        public string CCVer { get; set; }
    }

    public partial class MechLoadoutData : Resource
    {
        [Export]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [Export]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [Export]
        [JsonPropertyName("systems")]
        public MechEquipmentData[] Systems { get; set; }

        [Export]
        [JsonPropertyName("integratedSystems")]
        public MechEquipmentData[] IntegratedSystems { get; set; }

        [Export]
        [JsonPropertyName("mounts")]
        public MountData[] Mounts { get; set; }

        [Export]
        [JsonPropertyName("integratedMounts")]
        public MountData[] IntegratedMounts { get; set; }

        [Export]
        [JsonPropertyName("improved_armament")]
        public MountData ImprovedArmament { get; set; }

        [Export]
        [JsonPropertyName("superheavy_mounting")]
        public MountData SuperheavyMounting { get; set; }

        [Export]
        [JsonPropertyName("integratedWeapon")]
        public MountData IntegratedWeapon { get; set; }

        [Export]
        [JsonPropertyName("extraMounts")]
        public MountData[] ExtraMounts { get; set; }

        [Export]
        [JsonPropertyName("extraIntegratedMounts")]
        public MountData[] ExtraIntegratedMounts { get; set; }
    }

    public partial class MechEquipmentData : Resource
    {
        [Export]
        [JsonPropertyName("sp")]
        public int Sp { get; set; }

        [Export]
        [JsonPropertyName("tags")]
        public TagData[] Tags { get; set; }

        [Export]
        [JsonPropertyName("effect")]
        public string Effect { get; set; }

        [Export]
        [JsonPropertyName("talent_item")]
        public bool TalentItem { get; set; }

        [Export]
        [JsonPropertyName("frame_id")]
        public bool FrameId { get; set; }

        [Export]
        [JsonPropertyName("ammo")]
        public AmmoData[] Ammo { get; set; }

        [Export]
        [JsonPropertyName("no_mods")]
        public bool NoMods { get; set; }

        [Export]
        [JsonPropertyName("no_bonuses")]
        public bool NoBonuses { get; set; }

        [Export]
        [JsonPropertyName("no_synergies")]
        public bool NoSynergies { get; set; }
    }

    public partial class MountData : Resource
    {
        [Export]
        [JsonPropertyName("mount_type")]
        public MountType MountType { get; set; }

        [Export]
        [JsonPropertyName("lock")]
        public bool Lock { get; set; }

        [Export]
        [JsonPropertyName("slots")]
        public MechWeaponSlot[] Slots { get; set; }

        [Export]
        [JsonPropertyName("extra")]
        public MechWeaponSlot[] Extra { get; set; }

        [Export]
        [JsonPropertyName("modifiable")]
        public bool Modifiable { get; set; }
    }

    public partial class MechWeaponSlot : Resource
    {
        [Export]
        [JsonPropertyName("size")]
        public FittingSize Size { get; set; }

        [Export]
        [JsonPropertyName("weapon")]
        public MechWeapon Weapon { get; set; }
    }
    public partial class MechWeapon : Resource
    {
        [Export]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [Export]
        [JsonPropertyName("destroyed")]
        public bool Destroyed { get; set; }

        [Export]
        [JsonPropertyName("cascading")]
        public bool Cascading { get; set; }

        [Export]
        [JsonPropertyName("loaded")]
        public bool Loaded { get; set; }

        [Export]
        [JsonPropertyName("mod")]
        public ModData Mod { get; set; }

        [Export]
        [JsonPropertyName("flavorName")]
        public string FlavorName { get; set; }

        [Export]
        [JsonPropertyName("flavorDescription")]
        public string FlavorDescription { get; set; }

        [Export]
        [JsonPropertyName("customDamageType")]
        public string CustomDamageType { get; set; }

        [Export]
        [JsonPropertyName("maxUseOverride")]
        public int MaxUseOverride { get; set; }

        [Export]
        [JsonPropertyName("uses")]
        public int Uses { get; set; }

        [Export]
        [JsonPropertyName("selectedProfile")]
        public int SelectedProfile { get; set; }
    }

    public enum FittingSize
    {
        Auxiliary,
        Main,
        Flex,
        Heavy,
        Integrated,
        Superheavy
    }

}
