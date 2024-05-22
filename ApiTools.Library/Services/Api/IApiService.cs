using ApiTools.Library.Services.Api.Models;

namespace ApiTools.Library.Services.Api
{
    public interface IApiService
    {
        Task<string> CallApiAsync(string url, HttpAction httpAction = HttpAction.GET, bool formatJson = false);
        bool IsValidUrl(string url);
    }
}