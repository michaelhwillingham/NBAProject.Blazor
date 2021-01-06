// ReSharper disable InconsistentNaming

using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using NBAProject.Models.MySportsFeeds.ApiResponses;
using NBAProject.Models.Requests;
using NBAProject.Services.RequestHandlers;
using NBAProject.Tests.TestHelpers;
using Shouldly;

namespace NBAProject.Tests.Services.RequestHandlerTests
{
    public class GetTeamsHandlerTests
    {
        public async Task ShouldGetAllTeams()
        {
            var apiService = new ApiFixture<GetTeamsResponse>().ApiService;

            var request = new GetTeams {Stats = "none"};
            var handler = new GetTeamsHandler(apiService);

            var response = await handler.Handle(request, CancellationToken.None);
            var teams = response.Teams.ToList();

            teams.Count.ShouldBeGreaterThan(0);
        }

        public async Task ShouldGetAllTeamsWithStats()
        {
            var apiService = new ApiFixture<GetTeamsResponse>().ApiService;

            var request = new GetTeams();
            var handler = new GetTeamsHandler(apiService);

            var response = await handler.Handle(request, CancellationToken.None);
            var teamStats = response.Teams.Select(x => x.Stats).ToList();

            teamStats.Count.ShouldBeGreaterThan(0);
        }
    }
}