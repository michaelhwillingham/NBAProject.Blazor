using Newtonsoft.Json;

namespace NBAProject.Models.MySportsFeeds.Rank
{
    public class ConferenceRank : Ranking
    {
        [JsonProperty("conferenceName")] public string ConferenceName { get; set; }
    }
}