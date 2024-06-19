using Godot;
using System.Text.Json;
using System.Threading.Tasks;
using HttpClient = System.Net.Http.HttpClient;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using MASTMAN.Scripts.Data.Models;

namespace MASTMAN.Data
{
    public partial class BaseDataObject : Resource
    {
        Dictionary<string, Func<string, Task>> processors;
        private static readonly HttpClient client = new HttpClient();
        private bool _debugMode = false;
        public BaseDataObject(bool debug = false) 
        {
            processors = new Dictionary<string, Func<string, Task>>() {
            { "actions", async (url) => await ProcessFileListContent<ActionData>(url) },
            { "backgrounds", async (url) => await ProcessFileListContent<BackgroundData>(url) },
            { "core_bonuses", async (url) => await ProcessFileListContent<CoreBonusData>(url) },
            { "environments", async (url) => await ProcessFileListContent<EnvironmentData>(url) },
			//{ "factions", async (url) => await ProcessFileContent<FactionData>(url) },
			{ "frames", async (url) => await ProcessFileListContent<FrameData>(url) },
			//{ "glossary", async (url) => await ProcessFileContent<GlossaryData>(url) },
			{ "info", async (url) => await ProcessFileContent<ManifestData>(url) },
            { "manufacturers", async (url) => await ProcessFileListContent<ManufacturerData>(url) },
            { "mods", async (url) => await ProcessFileListContent<ModData>(url) },
            { "pilot_gear", async (url) => await ProcessFileListContent<PilotGearData>(url) },
            { "reserves", async (url) => await ProcessFileListContent<ReserveData>(url) },
            { "rules", async (url) => await ProcessFileContent<RuleData>(url) },
            { "sitreps", async (url) => await ProcessFileListContent<SitrepData>(url) },
            { "skills", async (url) => await ProcessFileListContent<SkillData>(url) },
            { "statuses", async (url) => await ProcessFileListContent<StatusData>(url) },
            { "systems", async (url) => await ProcessFileListContent<SystemData>(url) },
			//{ "tables", async (url) => await ProcessFileContent<TableData>(url) },
			{ "tags", async (url) => await ProcessFileListContent<TagData>(url) },
            { "talents", async (url) => await ProcessFileListContent<TalentData>(url) },
            { "weapons", async (url) => await ProcessFileListContent<WeaponData>(url) }
        };

            Task.Run(async () => await GetCoreJsonDataAsync());
        }

        private async Task GetCoreJsonDataAsync()
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

        private async Task ProcessFileListContent<T>(string url)
        {
            List<T> data = await GetFileListContent<T>(url);
            if (_debugMode)
            {
                GD.PrintRaw($"Content of {url}:\n");
                data.ForEach(item => GD.Print($"{item}"));
            }
        }

        private async Task ProcessFileContent<T>(string url)
        {
            T data = await GetFileContent<T>(url);
            if (_debugMode)
            {
                GD.PrintRaw($"Content of {url}:\n");
                GD.Print($"{data}");
            }
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
