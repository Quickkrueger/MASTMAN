using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MASTMAN.Data
{
    public class MechData
    {
        [JsonPropertyName("deleteTime")]
        public string DeleteTime { get; set; }

        [JsonPropertyName("expireTime")]
        public string ExpireTime { get; set; }

        [JsonPropertyName("lastModified")]
        public string LastModified { get; set; }

        [JsonPropertyName("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("notes")]
        public string Notes { get; set; }

        [JsonPropertyName("gm_note")]
        public string GMNote { get; set; }

        [JsonPropertyName("portrait")]
        public string Portrait { get; set; }

        [JsonPropertyName("cloud_portrait")]
        public string CloudPortrait { get; set; }

        [JsonPropertyName("frame")]
        public string Frame { get; set; }

        [JsonPropertyName("active")]
        public bool Active { get; set; }

        [JsonPropertyName("current_structure")]
        public int CurrentStructure { get; set; }

        [JsonPropertyName("current_move")]
        public int CurrentMove { get; set; }

        [JsonPropertyName("boost")]
        public int Boost { get; set; }

        [JsonPropertyName("current_hp")]
        public int CurrentHp { get; set; }

        [JsonPropertyName("overshield")]
        public int Overshield { get; set; }

        [JsonPropertyName("current_stress")]
        public int CurrentStress { get; set; }

        [JsonPropertyName("current_heat")]
        public int CurrentHeat { get; set; }

        [JsonPropertyName("current_repairs")]
        public int CurrentRepairs { get; set; }

        [JsonPropertyName("current_overcharge")]
        public int CurrentOvercharge { get; set; }

        [JsonPropertyName("current_core_energy")]
        public int CurrentCoreEnergy { get; set; }

        [JsonPropertyName("loadouts")]
        public MechLoadoutData[] Loadouts { get; set; }

        [JsonPropertyName("active_loadout_index")]
        public int ActiveLoadoutIndex { get; set; }

        [JsonPropertyName("statuses")]
        public string[] Statuses { get; set; }

        [JsonPropertyName("conditions")]
        public string[] Conditions { get; set; }

        [JsonPropertyName("resistances")]
        public string[] Resistances { get; set; }

        [JsonPropertyName("reactions")]
        public string[] Reactions { get; set; }

        [JsonPropertyName("burn")]
        public int Burn { get; set; }

        [JsonPropertyName("destroyed")]
        public bool Destroyed { get; set; }

        [JsonPropertyName("defeat")]
        public string Defeat { get; set; }

        [JsonPropertyName("activations")]
        public int Activations { get; set; }

        [JsonPropertyName("meltdown_imminent")]
        public bool MeltdownImminent { get; set; }

        [JsonPropertyName("reactor_destroyed")]
        public bool ReactorDestroyed { get; set; }

        [JsonPropertyName("core_active")]
        public bool CoreActive { get; set; }

        [JsonPropertyName("cc_ver")]
        public string CCVer { get; set; }
    }

    public class MechLoadoutData
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("systems")]
        public MechEquipmentData[] Systems { get; set; }

        [JsonPropertyName("integratedSystems")]
        public MechEquipmentData[] IntegratedSystems { get; set; }

        [JsonPropertyName("mounts")]
        public MountData[] Mounts { get; set; }

        [JsonPropertyName("integratedMounts")]
        public MountData[] IntegratedMounts { get; set; }

        [JsonPropertyName("improved_armament")]
        public MountData ImprovedArmament { get; set; }

        [JsonPropertyName("superheavy_mounting")]
        public MountData SuperheavyMounting { get; set; }

        [JsonPropertyName("integratedWeapon")]
        public MountData IntegratedWeapon { get; set; }

        [JsonPropertyName("extraMounts")]
        public MountData[] ExtraMounts { get; set; }

        [JsonPropertyName("extraIntegratedMounts")]
        public MountData[] ExtraIntegratedMounts { get; set; }
    }

    public class MechEquipmentData
    {
        [JsonPropertyName("sp")]
        public int Sp { get; set; }
        [JsonPropertyName("tags")]
        public List<TagData> Tags { get; set; }
        [JsonPropertyName("effect")]
        public string Effect { get; set; }
        [JsonPropertyName("talent_item")]
        public bool TalentItem { get; set; }
        [JsonPropertyName("frame_id")]
        public bool FrameId { get; set; }
        [JsonPropertyName("ammo")]
        public List<object> Ammo { get; set; }
        [JsonPropertyName("no_mods")]
        public bool NoMods { get; set; }
        [JsonPropertyName("no_bonuses")]
        public bool NoBonuses { get; set; }
        [JsonPropertyName("no_synergies")]
        public bool NoSynergies { get; set; }
    }

    public class MountData
    {
        [JsonPropertyName("mount_type")]
        public MountType MountType { get; set; }
        [JsonPropertyName("lock")]
        public bool Lock { get; set; }
        [JsonPropertyName("slots")]
        public List<MechWeaponSlot> Slots { get; set; }
        [JsonPropertyName("extra")]
        public List<MechWeaponSlot> Extra { get; set; }
        [JsonPropertyName("modifiable")]
        public bool Modifiable { get; set; }
    }

    public class MechWeaponSlot
    {
        [JsonPropertyName("size")]
        public FittingSize Size { get; set; }
        [JsonPropertyName("weapon")]
        public MechWeapon Weapon { get; set; }
    }
    public class MechWeapon
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("destroyed")]
        public bool Destroyed { get; set; }
        [JsonPropertyName("cascading")]
        public bool Cascading { get; set; }
        [JsonPropertyName("loaded")]
        public bool Loaded { get; set; }
        [JsonPropertyName("mod")]
        public object Mod { get; set; }
        [JsonPropertyName("flavorName")]
        public string FlavorName { get; set; }
        [JsonPropertyName("flavorDescription")]
        public string FlavorDescription { get; set; }
        [JsonPropertyName("customDamageType")]
        public object CustomDamageType { get; set; }
        [JsonPropertyName("maxUseOverride")]
        public int MaxUseOverride { get; set; }
        [JsonPropertyName("uses")]
        public int Uses { get; set; }
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
