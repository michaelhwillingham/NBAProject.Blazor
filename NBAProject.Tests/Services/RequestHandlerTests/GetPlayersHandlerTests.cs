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
    public class GetPlayersHandlerTests
    {
        public async Task ShouldGetAllPlayers()
        {
            var apiService = new ApiFixture<GetPlayersResponse>().ApiService;

            var request = new GetPlayers();
            var handler = new GetPlayersHandler(apiService);

            var response = await handler.Handle(request, CancellationToken.None);
            var players = response.Players.ToList();

            players.Count.ShouldBeGreaterThan(0);
        }

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