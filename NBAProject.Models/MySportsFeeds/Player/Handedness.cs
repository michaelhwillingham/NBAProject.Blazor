using NBAProject.Models.MySportsFeeds.Enums;
using Newtonsoft.Json;

namespace NBAProject.Models.MySportsFeeds.Player
{
    public class Handedness
    {
        [JsonProperty("shoots")] public Shoots? Shoots { get; set; }
    }
}