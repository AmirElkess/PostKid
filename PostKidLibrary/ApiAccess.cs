
namespace PostKidLibrary;

public class ApiAccess : IApiAccess
{
    private readonly HttpClient client = new();

    // add support for POST

    public async Task<string> callApiAsync(string url, HttpAction action = HttpAction.GET)
    {
        var response = await client.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            string json = await response.Content.ReadAsStringAsync();

            return json;
        }
        else
        {
            return $"Error: {response.StatusCode}";
        }

    }

    public bool isValidUrl(string url)
    {
        if (string.IsNullOrWhiteSpace(url))
        {
            return false;
        }

        return Uri.TryCreate(url, UriKind.Absolute, out Uri uriResult)
            && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
    }
}
