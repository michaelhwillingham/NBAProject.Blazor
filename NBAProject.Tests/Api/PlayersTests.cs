using System.Net.Http;
using System.Threading.Tasks;
using Moq;
using NBAProject.Services;
using Shouldly;

namespace NBAProject.Tests.Api
{
    public class PlayersTests
    {
        private ApiService _apiService;

        public void SetUp()
        {
            var httpClient = new Mock<HttpClient>();
            _apiService = new ApiService(httpClient.Object);
        }
        
        public async Task ShouldGetAllPlayers()
        {
            var players = await _apiService.GetAllPlayersAsync();

            players.ShouldNotBeNull();
        }
    }
}