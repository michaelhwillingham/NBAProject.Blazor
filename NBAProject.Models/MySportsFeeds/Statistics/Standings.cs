using Newtonsoft.Json;

namespace NBAProject.Models.MySportsFeeds.Statistics
{
    public class Standings
    {
        [JsonProperty("wins")] public long Wins { get; set; }

        [JsonProperty("losses")] public long Losses { get; set; }

        [JsonProperty("winPct")] public decimal WinPercentage { get; set; }

        [JsonProperty("gamesBack")] public long GamesBack { get; set; }
    }
}