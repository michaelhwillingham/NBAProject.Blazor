using NBAProject.Models.MySportsFeeds.Rank;
using Newtonsoft.Json;

namespace NBAProject.Models.MySportsFeeds.Team
{
    public class TeamElement
    {
        [JsonProperty("team")] public TeamDetails TeamDetails { get; set; }

        [JsonProperty("stats")] public Statistics.Statistics Stats { get; set; }

        [JsonProperty("overallRank")] public OverallRank OverallRank { get; set; }

        [JsonProperty("conferenceRank")] public ConferenceRank ConferenceRank { get; set; }

        [JsonProperty("divisionRank")] public DivisionRank DivisionRank { get; set; }

        [JsonProperty("playoffRank")] public PlayoffRank PlayoffRank { get; set; }
    }
}