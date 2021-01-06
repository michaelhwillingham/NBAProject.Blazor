using MediatR;
using NBAProject.Models.MySportsFeeds.ApiResponses;

namespace NBAProject.Models.Requests
{
    public class GetPlayers : IRequest<GetPlayersResponse>
    {
        public string Season { get; set; } = "current";

        public string Date { get; set; }

        public string Team { get; set; }

        public string RosterStatus { get; set; }

        public string Player { get; set; }

        public string Positions { get; set; }

        public string Country { get; set; }

        public string Sort { get; set; }

        public int? Offset { get; set; }

        public int? Limit { get; set; }

        public bool? Force { get; set; }
    }
}