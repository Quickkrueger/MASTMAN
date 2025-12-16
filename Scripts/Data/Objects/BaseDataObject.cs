using Godot;
using System.Text.Json;
using System.Threading.Tasks;
using HttpClient = System.Net.Http.HttpClient;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using MASTMAN.Scripts.Data.Models;

namespace MASTMAN.Data
{
    [GlobalClass]
    public partial class BaseDataObject : Resource
    {
        Dictionary<string, Func<string, Task>> processors;
        private static readonly HttpClient client = new HttpClient();
        private bool _debugMode = true;

        [Export]
        public ActionData[] Actions { get; set; }
        [Export]
        public BackgroundData[] Backgrounds { get; set; }
        [Export]
        public CoreBonusData[] CoreBonuses { get; set; }
        [Export]
        public EnvironmentData[] Environments { get; set; }
        [Export]
        public FrameData[] Frames { get; set; }
        [Export]
        public ManifestData Manifest { get; set; }
        [Export]
        public ManufacturerData[] Manufacturers { get; set; }
        [Export]
        public ModData[] Mods { get; set; }
        [Export]
        public PilotGearData[] PilotGear { get; set; }
        [Export]
        public ReserveData[] Reserves { get; set; }
        [Export]
        public RuleData Rules { get; set; }
        [Export]
        public SitrepData[] Sitreps { get; set; }
        [Export]
        public SkillData[] Skills { get; set; }
        [Export]
        public StatusData[] Statuses { get; set; }
        [Export]
        public SystemData[] Systems { get; set; }
        [Export]
        public TagData[] Tags { get; set; }
        [Export]
        public TalentData[] Talents { get; set; }
        [Export]
        public WeaponData[] Weapons { get; set; }



        public BaseDataObject() : this(false) { }

        public BaseDataObject(bool debug) 
        {
            processors = new Dictionary<string, Func<string, Task>>() {
            { "actions", async (url) => Actions = (await ProcessFileListContent<ActionData>(url)).ToArray() },
            { "backgrounds", async (url) => Backgrounds = (await ProcessFileListContent<BackgroundData>(url)).ToArray() },
            { "core_bonuses", async (url) => CoreBonuses = (await ProcessFileListContent<CoreBonusData>(url)).ToArray() },
            { "environments", async (url) => Environments = (await ProcessFileListContent<EnvironmentData>(url)).ToArray() },
			//{ "factions", async (url) => await ProcessFileContent<FactionData>(url) },
			{ "frames", async (url) => Frames = (await ProcessFileListContent<FrameData>(url)).ToArray() },
			//{ "glossary", async (url) => await ProcessFileContent<GlossaryData>(url) },
			{ "info", async (url) => Manifest = await ProcessFileContent<ManifestData>(url) },
            { "manufacturers", async (url) => Manufacturers = (await ProcessFileListContent<ManufacturerData>(url)).ToArray() },
            { "mods", async (url) => Mods = (await ProcessFileListContent < ModData >(url)).ToArray() },
            { "pilot_gear", async (url) => PilotGear = (await ProcessFileListContent < PilotGearData >(url)).ToArray() },
            { "reserves", async (url) => Reserves = (await ProcessFileListContent < ReserveData >(url)).ToArray() },
            { "rules", async (url) => Rules = await ProcessFileContent<RuleData>(url) },
            { "sitreps", async (url) => Sitreps = (await ProcessFileListContent < SitrepData >(url)).ToArray() },
            { "skills", async (url) => Skills = (await ProcessFileListContent < SkillData >(url)).ToArray() },
            { "statuses", async (url) => Statuses = (await ProcessFileListContent < StatusData >(url)).ToArray() },
            { "systems", async (url) => Systems = (await ProcessFileListContent < SystemData >(url)).ToArray() },
			//{ "tables", async (url) => await ProcessFileContent<TableData>(url) },
			{ "tags", async (url) => Tags = (await ProcessFileListContent < TagData >(url)).ToArray() },
            { "talents", async (url) => Talents = (await ProcessFileListContent < TalentData >(url)).ToArray() },
            { "weapons", async (url) => Weapons = (await ProcessFileListContent <WeaponData>(url)).ToArray() }
        };
        }

        public async Task GetCoreJsonDataAsync()
        {
            string repoUrl = "https://api.github.com/repos/massif-press/lancer-data/contents/lib";
            client.DefaultRequestHeaders.UserAgent.TryParseAdd("request"); // GitHub API requires a User-Agent header

            try
            {
                // Get the list of JSON files from the repository folder
                GitHubFile[] fileList = await GetFileListFromRepo(repoUrl);
                foreach (GitHubFile file in fileList)
                {
                    if (file.Type == "file" && file.Name.EndsWith(".json"))
                    {
                        foreach (string prefix in processors.Keys)
                        {
                            if (file.Name.StartsWith(prefix))
                            {
                                await processors[prefix](file.DownloadUrl);
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (_debugMode)
                {
                    GD.Print($"An error occurred: {ex.Message}");
                }
            }
        }

        private async Task<List<T>> ProcessFileListContent<T>(string url)
        {
            List<T> data = await GetFileListContent<T>(url);

            if (_debugMode)
            {
                GD.PrintRaw($"Content of {url}:\n");
                data.ForEach(item => GD.Print($"{item}"));
            }

            return data;
        }

        private async Task<T> ProcessFileContent<T>(string url)
        {
            T data = await GetFileContent<T>(url);

            if (_debugMode)
            {
                GD.PrintRaw($"Content of {url}:\n");
                GD.Print($"{data}");
            }

            return data;
        }


        private async Task<GitHubFile[]> GetFileListFromRepo(string repoUrl)
        {
            string response = await client.GetStringAsync(repoUrl);
            return JsonSerializer.Deserialize<GitHubFile[]>(response);
        }

        private async Task<List<T>> GetFileListContent<T>(string fileUrl)
        {
            string jsonString = await client.GetStringAsync(fileUrl);
            List<T> serializableClass = JsonSerializer.Deserialize<List<T>>(jsonString);

            return serializableClass;
        }
        private async Task<T> GetFileContent<T>(string fileUrl)
        {
            string jsonString = await client.GetStringAsync(fileUrl);
            T serializableClass = JsonSerializer.Deserialize<T>(jsonString);

            return serializableClass;
        }

    }

    public class GitHubFile
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("download_url")]
        public string DownloadUrl { get; set; }
    }
}
