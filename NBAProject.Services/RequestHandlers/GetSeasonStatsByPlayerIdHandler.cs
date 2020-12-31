using System.Threading;
using System.Threading.Tasks;
using MediatR;
using NBAProject.Models.Documents;
using NBAProject.Models.Queries;
using NBAProject.Services.MongoDb;

namespace NBAProject.Services.RequestHandlers
{
    public class GetSeasonStatsByPlayerIdHandler : IRequestHandler<GetSeasonStatsByPlayerId, PlayerSeasonStat>
    {
        private readonly IMongoRepository<PlayerSeasonStat> _mongo;

        public GetSeasonStatsByPlayerIdHandler(IMongoRepository<PlayerSeasonStat> mongo)
        {
            _mongo = mongo;
        }

        public async Task<PlayerSeasonStat> Handle(GetSeasonStatsByPlayerId request, CancellationToken token)
        {
            return await _mongo.FindOneAsync(x => x.PlayerID == request.PlayerID);
        }
    }
}