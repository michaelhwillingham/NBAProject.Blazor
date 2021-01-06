using System.Threading.Tasks;
using NBAProject.Models.MySportsFeeds.ApiResponses;
using RestSharp;

namespace NBAProject.Services.MySportsFeeds
{
    public interface IApiService<T> where T : ApiResponse
    {
        T Get(RestRequest getRequest);
        Task<T> GetAsync(RestRequest getRequest);
    }
}