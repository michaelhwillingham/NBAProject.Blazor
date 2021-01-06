using NBAProject.Models.MySportsFeeds.Player;
using Newtonsoft.Json;

namespace NBAProject.Models.MySportsFeeds.ApiResponses
{
    public class GetPlayersResponse : ApiResponse
    {
        [JsonProperty("players")] public PlayerElement[] Players { get; set; }

        // [JsonProperty("references")]
        // public References References { get; set; }
    }
}