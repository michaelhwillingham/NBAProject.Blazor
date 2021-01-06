using Newtonsoft.Json;

namespace NBAProject.Models.MySportsFeeds.Statistics
{
    public class Miscellaneous
    {
        [JsonProperty("fouls")] public long TotalFouls { get; set; }

        [JsonProperty("foulsPerGame")] public decimal FoulsPerGame { get; set; }

        [JsonProperty("foulsDrawn")] public long TotalFoulsDrawn { get; set; }

        [JsonProperty("foulsDrawnPerGame")] public decimal FoulsDrawnPerGame { get; set; }

        [JsonProperty("foulPers")] public long TotalPersonalFouls { get; set; }

        [JsonProperty("foulPersPerGame")] public decimal PersonalFoulsPerGame { get; set; }

        [JsonProperty("foulPersDrawn")] public long TotalPersonalFoulsDrawn { get; set; }

        [JsonProperty("foulPersDrawnPerGame")] public decimal PersonalFoulsDrawnPerGame { get; set; }
    }
}