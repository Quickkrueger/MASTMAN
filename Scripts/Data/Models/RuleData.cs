using Godot;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MASTMAN.Scripts.Data.Models
{
    public partial class RuleData : Resource
    {
        [Export]
        [JsonPropertyName("base_structure")]
        public int BaseStructure { get; set; }

        [Export]
        [JsonPropertyName("base_stress")]
        public int BaseStress { get; set; }

        [Export]
        [JsonPropertyName("base_grapple")]
        public int BaseGrapple { get; set; }

        [Export]
        [JsonPropertyName("base_ram")]
        public int BaseRam { get; set; }

        [Export]
        [JsonPropertyName("base_pilot_hp")]
        public int BasePilotHp { get; set; }

        [Export]
        [JsonPropertyName("base_pilot_evasion")]
        public int BasePilotEvasion { get; set; }

        [Export]
        [JsonPropertyName("base_pilot_edef")]
        public int BasePilotEdef { get; set; }

        [Export]
        [JsonPropertyName("base_pilot_speed")]
        public int BasePilotSpeed { get; set; }

        [Export]
        [JsonPropertyName("base_pilot_sensors")]
        public int BasePilotSensors { get; set; }

        [Export]
        [JsonPropertyName("base_pilot_save_target")]
        public int BasePilotSaveTarget { get; set; }

        [Export]
        [JsonPropertyName("minimum_pilot_skills")]
        public int MinimumPilotSkills { get; set; }

        [Export]
        [JsonPropertyName("minimum_mech_skills")]
        public int MinimumMechSkills { get; set; }

        [Export]
        [JsonPropertyName("minimum_pilot_talents")]
        public int MinimumPilotTalents { get; set; }

        [Export]
        [JsonPropertyName("trigger_bonus_per_rank")]
        public int TriggerBonusPerRank { get; set; }

        [Export]
        [JsonPropertyName("max_trigger_rank")]
        public int MaxTriggerRank { get; set; }

        [Export]
        [JsonPropertyName("max_pilot_level")]
        public int MaxPilotLevel { get; set; }

        [Export]
        [JsonPropertyName("max_pilot_weapons")]
        public int MaxPilotWeapons { get; set; }

        [Export]
        [JsonPropertyName("max_pilot_armor")]
        public int MaxPilotArmor { get; set; }

        [Export]
        [JsonPropertyName("max_pilot_gear")]
        public int MaxPilotGear { get; set; }

        [Export]
        [JsonPropertyName("max_frame_size")]
        public int MaxFrameSize { get; set; }

        [Export]
        [JsonPropertyName("max_mech_armor")]
        public int MaxMechArmor { get; set; }

        [Export]
        [JsonPropertyName("max_hase")]
        public int MaxHase { get; set; }

        [Export]
        [JsonPropertyName("mount_fittings")]
        public MountFittings MountFittings { get; set; }

        [Export]
        [JsonPropertyName("overcharge")]
        public string[] Overcharge { get; set; }

        [Export]
        [JsonPropertyName("skill_headers")]
        public SkillHeader[] SkillHeaders { get; set; }
    }

    public partial class MountFittings : Resource
    {
        [Export]
        [JsonPropertyName("Auxiliary")]
        public string[] Auxiliary { get; set; }

        [Export]
        [JsonPropertyName("Main")]
        public string[] Main { get; set; }

        [Export]
        [JsonPropertyName("Flex")]
        public string[] Flex { get; set; }

        [Export]
        [JsonPropertyName("Heavy")]
        public string[] Heavy { get; set; }
    }

    public partial class SkillHeader : Resource
    {
        [Export]
        [JsonPropertyName("attr")]
        public string Attr { get; set; }

        [Export]
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }

}
