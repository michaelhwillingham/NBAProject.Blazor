using Newtonsoft.Json;

namespace NBAProject.Models.MySportsFeeds.Rank
{
    public class Ranking
    {
        [JsonProperty("rank")] public long Rank { get; set; }

        [JsonProperty("gamesBack")] public decimal GamesBack { get; set; }
    }
}