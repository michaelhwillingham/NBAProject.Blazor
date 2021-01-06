using Newtonsoft.Json;

namespace NBAProject.Models.MySportsFeeds.Statistics
{
    public class Defense
    {
        [JsonProperty("tov")] public long TotalTurnovers { get; set; }

        [JsonProperty("tovPerGame")] public decimal TurnoversPerGame { get; set; }

        [JsonProperty("stl")] public long TotalSteals { get; set; }

        [JsonProperty("stlPerGame")] public decimal StealsPerGame { get; set; }

        [JsonProperty("blk")] public long TotalBlocks { get; set; }

        [JsonProperty("blkPerGame")] public decimal BlocksPerGame { get; set; }

        [JsonProperty("blkAgainst")] public long TotalBlocksAgainst { get; set; }

        [JsonProperty("blkAgainstPerGame")] public decimal BlocksAgainstPerGame { get; set; }

        [JsonProperty("ptsAgainst")] public long TotalPointsAgainst { get; set; }

        [JsonProperty("ptsAgainstPerGame")] public decimal PointsAgainstPerGame { get; set; }
    }
}