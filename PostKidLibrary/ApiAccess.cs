
using System.Text;

namespace PostKidLibrary;

public class ApiAccess : IApiAccess
{
    private readonly HttpClient client = new();


    public async Task<string> callApiAsync(
        string url,
        string content,
        HttpAction action = HttpAction.GET
        )
    {
        StringContent stringContent = new StringContent(content, Encoding.UTF8, "application/json");
        return await callApiAsync(url, stringContent, action);
    }

    public async Task<string> callApiAsync(
        string url,
        HttpContent? content = null,
        HttpAction action = HttpAction.GET
        )
    {
        HttpResponseMessage? response; 

        switch (action)
        {
            case HttpAction.GET:
                response = await client.GetAsync(url);
                break;
            case HttpAction.POST:
                response = await client.PostAsync(url, content);
                break;
            case HttpAction.PUT:
                response = await client.PutAsync(url, content);
                break;
            case HttpAction.PATCH:
                response = await client.PatchAsync(url, content);
                break;
            case HttpAction.DELETE:
                response = await client.DeleteAsync(url);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(action), action, null);
        }

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
