using Newtonsoft.Json;

namespace NBAProject.Models.MySportsFeeds.Rank
{
    public class DivisionRank : Ranking
    {
        [JsonProperty("divisionName")] public string DivisionName { get; set; }
    }
}