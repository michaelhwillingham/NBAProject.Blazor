using Newtonsoft.Json;

namespace NBAProject.Models.MySportsFeeds.Venue
{
    public class HomeVenue
    {
        [JsonProperty("id")] public long Id { get; set; }

        [JsonProperty("name")] public string Name { get; set; }
    }
}