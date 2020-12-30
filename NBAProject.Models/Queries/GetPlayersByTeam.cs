using System.Collections.Generic;
using MediatR;
using NBAProject.Models.Documents;

namespace NBAProject.Models.Queries
{
    public class GetPlayersByTeam : IRequest<IEnumerable<Player>>
    {
        public string Key { get; set; }
    }
}