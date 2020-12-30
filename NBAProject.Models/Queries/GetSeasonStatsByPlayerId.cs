// ReSharper disable InconsistentNaming

using MediatR;
using NBAProject.Models.Documents;

namespace NBAProject.Models.Queries
{
    public class GetSeasonStatsByPlayerId : IRequest<PlayerSeasonStat>
    {
        public int PlayerID { get; set; }
    }
}