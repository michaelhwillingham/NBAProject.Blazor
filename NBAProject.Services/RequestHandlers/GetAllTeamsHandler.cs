using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using NBAProject.Models.Documents;
using NBAProject.Models.Queries;
using NBAProject.Services.MongoDb;

namespace NBAProject.Services.RequestHandlers
{
    public class GetAllTeamsHandler : IRequestHandler<GetAllTeams, IEnumerable<Team>>
    {
        private readonly IMongoRepository<Team> _mongo;

        public GetAllTeamsHandler(IMongoRepository<Team> mongo)
        {
            _mongo = mongo;
        }

        public async Task<IEnumerable<Team>> Handle(GetAllTeams request, CancellationToken token)
        {
            return await _mongo.AllDocumentsToListAsync();
        }
    }
}