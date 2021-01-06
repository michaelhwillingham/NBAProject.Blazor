using Newtonsoft.Json;

namespace NBAProject.Models.MySportsFeeds.Statistics
{
    public class FreeThrows
    {
        [JsonProperty("ftAtt")] public long TotalFreeThrowAttempts { get; set; }

        [JsonProperty("ftAttPerGame")] public decimal FreeThrowAttemptsPerGame { get; set; }

        [JsonProperty("ftMade")] public long TotalFreeThrowsMade { get; set; }

        [JsonProperty("ftMadePerGame")] public long FreeThrowsMadePerGame { get; set; }

        [JsonProperty("ftPct")] public decimal FreeThrowPercentage { get; set; }
    }
}