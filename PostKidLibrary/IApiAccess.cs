
namespace PostKidLibrary
{
    public interface IApiAccess
    {
        Task<string> callApiAsync(string url, HttpAction action = HttpAction.GET);
        bool isValidUrl(string url);
    }
}