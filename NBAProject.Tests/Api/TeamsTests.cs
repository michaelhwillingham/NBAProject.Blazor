using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Moq;
using NBAProject.Services;
using Shouldly;

namespace NBAProject.Tests.Api
{
    public class TeamsTests
    {
        private ApiService _apiService;

        public void SetUp()
        {
            var httpClient = new Mock<HttpClient>();
            _apiService = new ApiService(httpClient.Object);
        }
        
        public async Task ShouldGetAllTeams()
        {
            var teams = (await _apiService.GetAllTeamsAsync()).ToList();

            teams.Count.ShouldBe(30);
            teams.SingleOrDefault(x => x.Name == "Mavericks").ShouldNotBeNull();
        }
    }
}