using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using NBAProject.Models.Documents;
using NBAProject.Models.Queries;
using NBAProject.Services.MongoDb;

namespace NBAProject.Services.RequestHandlers
{
    public class GetAllPlayerSeasonStatsHandler : IRequestHandler<GetAllPlayerSeasonStats, IEnumerable<PlayerSeasonStat>>
    {
        private readonly IMongoRepository<PlayerSeasonStat> _mongo;

        public GetAllPlayerSeasonStatsHandler(IMongoRepository<PlayerSeasonStat> mongo)
        {
            _mongo = mongo;
        }

        public async Task<IEnumerable<PlayerSeasonStat>> Handle(GetAllPlayerSeasonStats request, CancellationToken token)
        {
            return await _mongo.AllDocumentsToListAsync();
        }
    }
}