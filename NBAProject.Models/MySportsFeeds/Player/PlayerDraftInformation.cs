using NBAProject.Models.MySportsFeeds.Team;
using Newtonsoft.Json;

namespace NBAProject.Models.MySportsFeeds.Player
{
    public class PlayerDraftInformation
    {
        [JsonProperty("year")] public long Year { get; set; }

        [JsonProperty("team")] public TeamAsOfDate Team { get; set; }

        [JsonProperty("pickTeam")] public TeamAsOfDate PickTeam { get; set; }

        [JsonProperty("round")] public long Round { get; set; }

        [JsonProperty("roundPick")] public long RoundPick { get; set; }

        [JsonProperty("overallPick")] public long OverallPick { get; set; }
    }
}