using Newtonsoft.Json;

namespace NBAProject.Models.MySportsFeeds.Statistics
{
    public class Statistics
    {
        [JsonProperty("gamesPlayed")] public long GamesPlayed { get; set; }

        [JsonProperty("fieldGoals")] public FieldGoals FieldGoals { get; set; }

        [JsonProperty("freeThrows")] public FreeThrows FreeThrows { get; set; }

        [JsonProperty("rebounds")] public Rebounds Rebounds { get; set; }

        [JsonProperty("offense")] public Offense Offense { get; set; }

        [JsonProperty("defense")] public Defense Defense { get; set; }

        [JsonProperty("miscellaneous")] public Miscellaneous Miscellaneous { get; set; }

        [JsonProperty("standings")] public Standings Standings { get; set; }
    }
}