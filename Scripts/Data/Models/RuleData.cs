using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MASTMAN.Scripts.Data.Models
{
    public class RuleData
    {
        [JsonPropertyName("base_structure")]
        public int BaseStructure { get; set; }

        [JsonPropertyName("base_stress")]
        public int BaseStress { get; set; }

        [JsonPropertyName("base_grapple")]
        public int BaseGrapple { get; set; }

        [JsonPropertyName("base_ram")]
        public int BaseRam { get; set; }

        [JsonPropertyName("base_pilot_hp")]
        public int BasePilotHp { get; set; }

        [JsonPropertyName("base_pilot_evasion")]
        public int BasePilotEvasion { get; set; }

        [JsonPropertyName("base_pilot_edef")]
        public int BasePilotEdef { get; set; }

        [JsonPropertyName("base_pilot_speed")]
        public int BasePilotSpeed { get; set; }

        [JsonPropertyName("base_pilot_sensors")]
        public int BasePilotSensors { get; set; }

        [JsonPropertyName("base_pilot_save_target")]
        public int BasePilotSaveTarget { get; set; }

        [JsonPropertyName("minimum_pilot_skills")]
        public int MinimumPilotSkills { get; set; }

        [JsonPropertyName("minimum_mech_skills")]
        public int MinimumMechSkills { get; set; }

        [JsonPropertyName("minimum_pilot_talents")]
        public int MinimumPilotTalents { get; set; }

        [JsonPropertyName("trigger_bonus_per_rank")]
        public int TriggerBonusPerRank { get; set; }

        [JsonPropertyName("max_trigger_rank")]
        public int MaxTriggerRank { get; set; }

        [JsonPropertyName("max_pilot_level")]
        public int MaxPilotLevel { get; set; }

        [JsonPropertyName("max_pilot_weapons")]
        public int MaxPilotWeapons { get; set; }

        [JsonPropertyName("max_pilot_armor")]
        public int MaxPilotArmor { get; set; }

        [JsonPropertyName("max_pilot_gear")]
        public int MaxPilotGear { get; set; }

        [JsonPropertyName("max_frame_size")]
        public int MaxFrameSize { get; set; }

        [JsonPropertyName("max_mech_armor")]
        public int MaxMechArmor { get; set; }

        [JsonPropertyName("max_hase")]
        public int MaxHase { get; set; }

        [JsonPropertyName("mount_fittings")]
        public MountFittings MountFittings { get; set; }

        [JsonPropertyName("overcharge")]
        public List<string> Overcharge { get; set; }

        [JsonPropertyName("skill_headers")]
        public List<SkillHeader> SkillHeaders { get; set; }
    }

    public class MountFittings
    {
        [JsonPropertyName("Auxiliary")]
        public List<string> Auxiliary { get; set; }

        [JsonPropertyName("Main")]
        public List<string> Main { get; set; }

        [JsonPropertyName("Flex")]
        public List<string> Flex { get; set; }

        [JsonPropertyName("Heavy")]
        public List<string> Heavy { get; set; }
    }

    public class SkillHeader
    {
        [JsonPropertyName("attr")]
        public string Attr { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }

}
