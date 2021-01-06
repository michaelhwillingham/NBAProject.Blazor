using Newtonsoft.Json;

namespace NBAProject.Models.MySportsFeeds.Statistics
{
    public class Offense
    {
        [JsonProperty("ast")] public long TotalAssists { get; set; }

        [JsonProperty("astPerGame")] public decimal AssistsPerGame { get; set; }

        [JsonProperty("pts")] public long TotalPoints { get; set; }

        [JsonProperty("ptsPerGame")] public decimal PointsPerGame { get; set; }
    }
}