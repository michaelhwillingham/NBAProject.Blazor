using NBAProject.Models.MySportsFeeds.Team;
using Newtonsoft.Json;

namespace NBAProject.Models.MySportsFeeds.Player
{
    public class PlayerElement
    {
        [JsonProperty("player")] public PlayerDetails PlayerDetails { get; set; }

        [JsonProperty("teamAsOfDate")] public TeamAsOfDate TeamAsOfDate { get; set; }
    }
}