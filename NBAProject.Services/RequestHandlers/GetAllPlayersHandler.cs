using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using NBAProject.Models.Documents;
using NBAProject.Models.Queries;
using NBAProject.Services.MongoDb;

namespace NBAProject.Services.RequestHandlers
{
    public class GetAllPlayersHandler : IRequestHandler<GetAllPlayers, IEnumerable<Player>>
    {
        private readonly IMongoRepository<Player> _mongo;

        public GetAllPlayersHandler(IMongoRepository<Player> mongo)
        {
            _mongo = mongo;
        }

        public async Task<IEnumerable<Player>> Handle(GetAllPlayers request, CancellationToken token)
        {
            return await _mongo.AllDocumentsToListAsync();
        }
    }
}