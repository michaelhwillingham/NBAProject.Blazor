using System.Collections.Generic;
using System.Threading.Tasks;
using NBAProject.Models;

namespace NBAProject.Services
{
    public interface IApiService
    {
        public Task<IEnumerable<Team>> GetAllTeamsAsync();
        public Task<string> GetAllPlayersAsync();
    }
}