using Godot;
using System.Text.Json;
using System.Threading.Tasks;
using HttpClient = System.Net.Http.HttpClient;
using System.Text.Json.Serialization;
using System;

public partial class Data_Manager : Node
{
	private static readonly HttpClient client = new HttpClient();
	public override void _Ready()
	{
		Task.Run(async() => await GetCoreJsonDataAsync());
	}

	static async Task GetCoreJsonDataAsync()
	{
		string repoUrl = "https://api.github.com/repos/massif-press/lancer-data/contents/lib";
		client.DefaultRequestHeaders.UserAgent.TryParseAdd("request"); // GitHub API requires a User-Agent header

		try
		{
			// Get the list of JSON files from the repository folder
			var fileList = await GetFileListFromRepo(repoUrl);
			foreach (var file in fileList)
			{
				if (file.Type == "file" && file.Name.EndsWith(".json"))
				{
					// Fetch and read each JSON file
					var jsonContent =  await GetFileContent(file.DownloadUrl);
					GD.Print($"Content of {file.Name}:\n{jsonContent}\n");
				}
			}
		}
		catch (Exception ex)
		{
			GD.Print($"An error occurred: {ex.Message}");
		}
	}

	static async Task<GitHubFile[]> GetFileListFromRepo(string repoUrl)
	{
		string response = await client.GetStringAsync(repoUrl);
		return JsonSerializer.Deserialize<GitHubFile[]>(response);
	}

	static async Task<string> GetFileContent(string fileUrl)
	{
		return await client.GetStringAsync(fileUrl);
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
