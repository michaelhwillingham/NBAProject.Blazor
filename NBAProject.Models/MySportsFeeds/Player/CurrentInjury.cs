using Newtonsoft.Json;

namespace NBAProject.Models.MySportsFeeds.Player
{
    public class CurrentInjury
    {
        [JsonProperty("description")] public string Description { get; set; }

        [JsonProperty("playingProbability")] public string PlayingProbability { get; set; }
    }
}