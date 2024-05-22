using ApiTools.Library.Services.Api.Models;
using System.Text.Json;

namespace ApiTools.Library.Services.Api;

public class ApiService : IApiService
{
    private readonly HttpClient _httpClient = new();

    public async Task<string> CallApiAsync(string url, HttpAction httpAction = HttpAction.GET, bool formatJson = false)
    {
        var response = await _httpClient.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            var json = await response.Content.ReadAsStringAsync();
            var jsonElement = JsonSerializer.Deserialize<JsonElement>(json);

            if (formatJson)
            {
                json = JsonSerializer.Serialize(jsonElement,
                    new JsonSerializerOptions { WriteIndented = true });
            }

            return json;
        }
        else
        {
            return $"Error: {response.StatusCode}";
        }
    }

    public bool IsValidUrl(string url)
    {
        if (string.IsNullOrWhiteSpace(url))
        {
            return false;
        }

        bool isValid = Uri.TryCreate(url, UriKind.Absolute, out var uriOut)
                        && (uriOut.Scheme == Uri.UriSchemeHttps);

        return isValid;
    }
}
