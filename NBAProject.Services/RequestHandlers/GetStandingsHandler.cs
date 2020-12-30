using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using NBAProject.Models.Documents;
using NBAProject.Models.Queries;
using NBAProject.Services.MongoDb;

namespace NBAProject.Services.RequestHandlers
{
    public class GetStandingsHandler : IRequestHandler<GetStandings, IEnumerable<Standing>>
    {
        private readonly IMongoRepository<Standing> _mongo;

        public GetStandingsHandler(IMongoRepository<Standing> mongo)
        {
            _mongo = mongo;
        }

        public async Task<IEnumerable<Standing>> Handle(GetStandings request, CancellationToken cancellationToken)
        {
            return await _mongo.AllDocumentsToListAsync();
        }
    }
}