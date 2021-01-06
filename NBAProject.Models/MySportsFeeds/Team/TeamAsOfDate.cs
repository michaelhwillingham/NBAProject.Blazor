using Newtonsoft.Json;

namespace NBAProject.Models.MySportsFeeds.Team
{
    public class TeamAsOfDate
    {
        [JsonProperty("id")] public long Id { get; set; }

        [JsonProperty("abbreviation")] public string Abbreviation { get; set; }
    }
}