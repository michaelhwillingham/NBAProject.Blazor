using System.Threading.Tasks;

namespace NBAProject.Services
{
    public interface IApiService
    {
        public Task<string> GetAllTeamsAsync();
        public Task<string> GetAllPlayersAsync();
    }
}