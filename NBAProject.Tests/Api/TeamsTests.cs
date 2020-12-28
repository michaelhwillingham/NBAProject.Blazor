using System;
using System.Net.Http;
using System.Threading.Tasks;
using Moq;
using NBAProject.Services;
using Newtonsoft.Json;
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
            var teams = await _apiService.GetAllTeamsAsync();
            Console.WriteLine(JsonConvert.SerializeObject(teams, Formatting.Indented));
            teams.ShouldNotBeNull();
        }
    }
}