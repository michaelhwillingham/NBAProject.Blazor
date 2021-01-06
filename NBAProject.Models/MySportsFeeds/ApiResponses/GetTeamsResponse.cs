using NBAProject.Models.MySportsFeeds.Team;
using Newtonsoft.Json;

namespace NBAProject.Models.MySportsFeeds.ApiResponses
{
    public class GetTeamsResponse : ApiResponse
    {
        [JsonProperty("teams")] public TeamElement[] Teams { get; set; }

        // [JsonProperty("references")]
        // public References References { get; set; }
    }
}