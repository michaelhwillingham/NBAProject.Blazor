using MediatR;
using NBAProject.Models.MySportsFeeds.ApiResponses;

namespace NBAProject.Models.Requests
{
    public class GetTeams : IRequest<GetTeamsResponse>
    {
        public string Season { get; set; } = "current";

        public string Date { get; set; }

        public string Team { get; set; }

        public string Stats { get; set; }

        public bool? Force { get; set; }
    }
}