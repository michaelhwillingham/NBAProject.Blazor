using Newtonsoft.Json;

namespace NBAProject.Models.MySportsFeeds.Statistics
{
    public class FieldGoals
    {
        [JsonProperty("fgAtt")] public long TotalFieldGoalAttempts { get; set; }

        [JsonProperty("fgAttPerGame")] public decimal FieldGoalAttemptsPerGame { get; set; }

        [JsonProperty("fgMade")] public long TotalFieldGoalsMade { get; set; }

        [JsonProperty("fgMadePerGame")] public decimal FieldGoalsMadePerGame { get; set; }

        [JsonProperty("fgPct")] public decimal FieldGoalPercentage { get; set; }

        [JsonProperty("fg2PtAtt")] public long TotalTwoPointFieldGoalAttempts { get; set; }

        [JsonProperty("fg2PtAttPerGame")] public decimal TwoPointFieldGoalAttemptsPerGame { get; set; }

        [JsonProperty("fg2PtMade")] public long TotalTwoPointFieldGoalsMade { get; set; }

        [JsonProperty("fg2PtMadePerGame")] public decimal TwoPointFieldGoalsMadePerGame { get; set; }

        [JsonProperty("fg2PtPct")] public decimal TwoPointFieldGoalPercentage { get; set; }

        [JsonProperty("fg3PtAtt")] public long TotalThreePointFieldGoalAttempts { get; set; }

        [JsonProperty("fg3PtAttPerGame")] public decimal ThreePointFieldGoalAttemptsPerGame { get; set; }

        [JsonProperty("fg3PtMade")] public long TotalThreePointFieldGoalsMade { get; set; }

        [JsonProperty("fg3PtMadePerGame")] public decimal ThreePointFieldGoalsMadePerGame { get; set; }

        [JsonProperty("fg3PtPct")] public decimal ThreePointFieldGoalPercentage { get; set; }
    }
}