using Godot;
using System.Text.Json;
using System.Threading.Tasks;
using HttpClient = System.Net.Http.HttpClient;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using MASTMAN.Data;
using System.Net.Http.Json;

public partial class Data_Manager : Node
{

	Dictionary<string, Func<string, Task>> processors;
	private static readonly HttpClient client = new HttpClient();
	public override void _Ready()
	 {
		processors = new Dictionary<string, Func<string, Task>>() {
			{ "actions", async (url) => await ProcessFileContent<ActionData>(url) },
			{ "backgrounds", async (url) => await ProcessFileContent<BackgroundData>(url) },
			{ "core_bonuses", async (url) => await ProcessFileContent<CoreBonusData>(url) },
			{ "environments", async (url) => await ProcessFileContent<EnvironmentData>(url) },
			//{ "factions", async (url) => await ProcessFileContent<FactionData>(url) },
			{ "frames", async (url) => await ProcessFileContent<FrameData>(url) },
			//{ "glossary", async (url) => await ProcessFileContent<GlossaryData>(url) },
			{ "info", async (url) => await ProcessFileContent<ManifestData>(url) },
			{ "manufacturers", async (url) => await ProcessFileContent<ManufacturerData>(url) },
			{ "mods", async (url) => await ProcessFileContent<ModData>(url) },
			{ "pilot_gear", async (url) => await ProcessFileContent<PilotGearData>(url) },
			{ "reserves", async (url) => await ProcessFileContent<ReserveData>(url) },
			{ "rules", async (url) => await ProcessFileContent<RuleData>(url) },
			{ "sitreps", async (url) => await ProcessFileContent<SitrepData>(url) },
			{ "skills", async (url) => await ProcessFileContent<SkillData>(url) },
			{ "statuses", async (url) => await ProcessFileContent<StatusData>(url) },
			{ "systems", async (url) => await ProcessFileContent<SystemData>(url) },
			//{ "tables", async (url) => await ProcessFileContent<TableData>(url) },
			{ "tags", async (url) => await ProcessFileContent<TagData>(url) },
			{ "talents", async (url) => await ProcessFileContent<TalentData>(url) },
			{ "weapons", async (url) => await ProcessFileContent<WeaponData>(url) }
		};

		Task.Run(async() => await GetCoreJsonDataAsync());
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
			GD.Print($"An error occurred: {ex.Message}");
		}
	}

	private async Task ProcessFileContent<T>(string url)
	{
		List<T> data = await GetFileContent<T>(url);
		GD.PrintRaw($"Content of {url}:\n");
		data.ForEach(item => GD.Print($"{item}"));
	}

	private async Task<GitHubFile[]> GetFileListFromRepo(string repoUrl)
	{
		string response = await client.GetStringAsync(repoUrl);
		return JsonSerializer.Deserialize<GitHubFile[]>(response);
	}

	private async Task<List<T>> GetFileContent<T>(string fileUrl)
	{
		string jsonString = await client.GetStringAsync(fileUrl);
		List<T> serializableClass = JsonSerializer.Deserialize<List<T>>(jsonString);

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
