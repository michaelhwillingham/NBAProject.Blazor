using Newtonsoft.Json;

namespace NBAProject.Models.MySportsFeeds.Statistics
{
    public class Rebounds
    {
        [JsonProperty("offReb")] public long TotalOffensiveRebounds { get; set; }

        [JsonProperty("offRebPerGame")] public decimal OffensiveReboundsPerGame { get; set; }

        [JsonProperty("defReb")] public long TotalDefensiveRebounds { get; set; }

        [JsonProperty("defRebPerGame")] public decimal DefensiveReboundsPerGame { get; set; }

        [JsonProperty("reb")] public long TotalRebounds { get; set; }

        [JsonProperty("rebPerGame")] public decimal ReboundsPerGame { get; set; }
    }
}