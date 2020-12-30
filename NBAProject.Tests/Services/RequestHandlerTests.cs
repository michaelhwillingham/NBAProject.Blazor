// ReSharper disable InconsistentNaming

using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using NBAProject.Models.Documents;
using NBAProject.Models.Queries;
using NBAProject.Services.RequestHandlers;
using NBAProject.Tests.TestHelpers;
using Shouldly;

namespace NBAProject.Tests.Services
{
    public class RequestHandlerTests
    {
        public async Task ShouldGetAllTeams()
        {
            var mongoRepository = new MongoFixture<Team>().MongoRepository;

            var request = new GetAllTeams();
            var handler = new GetAllTeamsHandler(mongoRepository);

            var response = await handler.Handle(request, CancellationToken.None);
            var teams = response.ToList();

            teams.Count.ShouldBe(30);
            teams.SingleOrDefault(x => x.Name == "Mavericks").ShouldNotBeNull();
        }

        public async Task ShouldGetStandings()
        {
            var mongoRepository = new MongoFixture<Standing>().MongoRepository;

            var request = new GetStandings();
            var handler = new GetStandingsHandler(mongoRepository);

            var response = await handler.Handle(request, CancellationToken.None);
            var standings = response.ToList();

            standings.Count.ShouldBe(30);
            standings.SingleOrDefault(x => x.Name == "Mavericks").ShouldNotBeNull();
        }

        public async Task ShouldGetAllPlayers()
        {
            var mongoRepository = new MongoFixture<Player>().MongoRepository;

            var request = new GetAllPlayers();
            var handler = new GetAllPlayersHandler(mongoRepository);

            var response = await handler.Handle(request, CancellationToken.None);
            var players = response.ToList();

            players.Count.ShouldBeGreaterThan(0);
            players.Select(x => x.FirstName).ShouldContain("Giannis");
        }

        public async Task ShouldGetPlayersByTeam()
        {
            var mongo = new MongoFixture<Player>().MongoRepository;

            var request = new GetPlayersByTeam {Key = "DAL"};
            var handler = new GetPlayersByTeamHandler(mongo);

            var response = await handler.Handle(request, CancellationToken.None);
            var players = response.ToList();

            players.Count.ShouldBeGreaterThan(0);
            players.Select(x => x.FirstName).ShouldContain("Luka");
        }

        public async Task ShouldGetAllPlayerSeasonStats()
        {
            var mongo = new MongoFixture<PlayerSeasonStat>().MongoRepository;

            var request = new GetAllPlayerSeasonStats();
            var handler = new GetAllPlayerSeasonStatsHandler(mongo);

            var response = await handler.Handle(request, CancellationToken.None);
            var playerSeasonStats = response.ToList();

            playerSeasonStats.Count.ShouldBeGreaterThan(0);
            playerSeasonStats.Sum(x => x.Points).ShouldBeGreaterThan(0);
            playerSeasonStats.Sum(x => x.Rebounds).ShouldBeGreaterThan(0);
            playerSeasonStats.Sum(x => x.Assists).ShouldBeGreaterThan(0);
        }
        
        public async Task ShouldGetSeasonStatsByPlayerID()
        {
            var playerMongo = new MongoFixture<Player>().MongoRepository;
            var lukaDoncic = await playerMongo.FindOneAsync(x => x.FirstName == "Luka" && x.Jersey == 77);

            var statsMongo = new MongoFixture<PlayerSeasonStat>().MongoRepository;

            var request = new GetSeasonStatsByPlayerId{PlayerID = lukaDoncic.PlayerID};
            var handler = new GetSeasonStatsByPlayerIdHandler(statsMongo);

            var lukaDoncicStats = await handler.Handle(request, CancellationToken.None);
            
            lukaDoncicStats.Name.ShouldBe("Luka Doncic");
            lukaDoncicStats.Points.ShouldNotBe(0);
            lukaDoncicStats.Rebounds.ShouldNotBe(0);
            lukaDoncicStats.Assists.ShouldNotBe(0);
        }
    }
}