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
    public class GetTeamsHandlerTests
    {
        [Fact]
        public async Task ShouldGetAllTeams()
        {
            var apiService = new ApiFixture<GetTeamsResponse>().ApiService;

            var request = new GetTeams();
            var handler = new GetTeamsHandler(apiService);

            var response = await handler.Handle(request, CancellationToken.None);
            var teams = response.Teams.ToList();

            teams.Count.ShouldBeGreaterThan(0);
        }
    }
}