using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MASTMAN.Data
{
    public class PilotData
    {
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

        [JsonPropertyName("dead")]
        public bool Dead { get; set; }

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

        [JsonPropertyName("mechs")]
        public List<FrameData> Mechs { get; set; }

        [JsonPropertyName("cc_ver")]
        public string CcVer { get; set; }

        [JsonPropertyName("special_equipment")]
        public PilotGearData SpecialEquipment { get; set; }

        [JsonPropertyName("combat_history")]
        public CombatHistory CombatHistory { get; set; }

        [JsonPropertyName("state")]
        public State State { get; set; }

        [JsonPropertyName("lastModified")]
        public string LastModified { get; set; }

        [JsonPropertyName("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonPropertyName("expireTime")]
        public string ExpireTime { get; set; }

        [JsonPropertyName("deleteTime")]
        public string DeleteTime { get; set; }

        [JsonPropertyName("lastUpdate_cloud")]
        public string LastUpdateCloud { get; set; }

        [JsonPropertyName("lastSync")]
        public string LastSync { get; set; }

        [JsonPropertyName("shareCode")]
        public string ShareCode { get; set; }

        [JsonPropertyName("shareCodeExpiry")]
        public string ShareCodeExpiry { get; set; }

        [JsonPropertyName("skills")]
        public List<SkillData> Skills { get; set; }

        [JsonPropertyName("talents")]
        public List<TalentData> Talents { get; set; }

        [JsonPropertyName("mechSkills")]
        public List<int> MechSkills { get; set; }

        [JsonPropertyName("counter_data")]
        public List<string> CounterData { get; set; }

        [JsonPropertyName("custom_counters")]
        public List<string> CustomCounters { get; set; }

        [JsonPropertyName("core_bonuses")]
        public List<string> CoreBonuses { get; set; }

        [JsonPropertyName("licenses")]
        public List<License> Licenses { get; set; }

        [JsonPropertyName("reserves")]
        public List<string> Reserves { get; set; }

        [JsonPropertyName("orgs")]
        public List<string> Orgs { get; set; }

        [JsonPropertyName("bondId")]
        public string BondId { get; set; }

        [JsonPropertyName("xp")]
        public int Xp { get; set; }

        [JsonPropertyName("stress")]
        public int Stress { get; set; }

        [JsonPropertyName("isBroken")]
        public bool IsBroken { get; set; }

        [JsonPropertyName("burdens")]
        public List<string> Burdens { get; set; }

        [JsonPropertyName("bondPowers")]
        public List<BondPower> BondPowers { get; set; }

        [JsonPropertyName("powerSelections")]
        public int PowerSelections { get; set; }

        [JsonPropertyName("maxStress")]
        public int MaxStress { get; set; }

        [JsonPropertyName("bondAnswers")]
        public List<string> BondAnswers { get; set; }

        [JsonPropertyName("minorIdeal")]
        public string MinorIdeal { get; set; }

        [JsonPropertyName("clocks")]
        public List<string> Clocks { get; set; }

        [JsonPropertyName("group")]
        public string Group { get; set; }

        [JsonPropertyName("sort_index")]
        public int SortIndex { get; set; }

        [JsonPropertyName("portrait")]
        public string Portrait { get; set; }

        [JsonPropertyName("cloud_portrait")]
        public string CloudPortrait { get; set; }

        [JsonPropertyName("loadout")]
        public List<PilotGearData> GearLoadout { get; set; }

        [JsonPropertyName("brews")]
        public List<string> Brews { get; set; }
    }
}
