using Newtonsoft.Json;

namespace NBAProject.Models.MySportsFeeds.Rank
{
    public class PlayoffRank
    {
        [JsonProperty("conferenceName")] public string ConferenceName { get; set; }

        [JsonProperty("divisionName")] public object DivisionName { get; set; }

        [JsonProperty("appliesTo")] public string AppliesTo { get; set; }

        [JsonProperty("rank")] public long Rank { get; set; }
    }
}