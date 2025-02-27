

namespace PostKidLibrary
{
    public interface IApiAccess
    {
        Task<string> callApiAsync(string url, string content, HttpAction action = HttpAction.GET);
        Task<string> callApiAsync(string url, HttpContent? content = null, HttpAction action = HttpAction.GET);
        bool isValidUrl(string url);
    }
}