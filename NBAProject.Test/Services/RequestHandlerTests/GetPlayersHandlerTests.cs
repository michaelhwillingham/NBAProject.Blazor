using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using NBAProject.Models.MySportsFeeds.ApiResponses;
using NBAProject.Models.Requests;
using NBAProject.Services.RequestHandlers;
using NBAProject.Test.TestHelpers;
using Shouldly;
using Xunit;

namespace NBAProject.Test.Services.RequestHandlerTests
{
    public class GetPlayersHandlerTests
    {
        [Fact]
        public async Task ShouldGetAllPlayers()
        {
            var apiService = new ApiFixture<GetPlayersResponse>().ApiService;

            var request = new GetPlayers();
            var handler = new GetPlayersHandler(apiService);

            var response = await handler.Handle(request, CancellationToken.None);
            var players = response.Players.ToList();

            players.Count.ShouldBeGreaterThan(0);
        }

        [Fact]
        public async Task ShouldGetPlayersByTeam()
        {
            var apiService = new ApiFixture<GetPlayersResponse>().ApiService;

            var request = new GetPlayers {Team = "dal", RosterStatus = "assigned-to-roster"};
            var handler = new GetPlayersHandler(apiService);

            var response = await handler.Handle(request, CancellationToken.None);
            var players = response.Players.ToList();

            players.Count.ShouldBeGreaterThan(0);
        }
    }
}