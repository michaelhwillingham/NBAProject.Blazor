using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using NBAProject.Models.Documents;
using NBAProject.Models.Queries;
using NBAProject.Services.MongoDb;

namespace NBAProject.Services.RequestHandlers
{
    public class GetPlayersByTeamHandler : IRequestHandler<GetPlayersByTeam, IEnumerable<Player>>
    {
        private readonly IMongoRepository<Player> _mongo;

        public GetPlayersByTeamHandler(IMongoRepository<Player> mongo)
        {
            _mongo = mongo;
        }

        public async Task<IEnumerable<Player>> Handle(GetPlayersByTeam request, CancellationToken token)
        {
            return await Task.Run(() => _mongo.FilterBy(x => x.Team == request.Key));
        }
    }
}