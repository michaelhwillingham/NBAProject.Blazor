using Newtonsoft.Json;

namespace NBAProject.Models.MySportsFeeds.Other
{
    public class SocialMediaAccount
    {
        [JsonProperty("mediaType")] public string SocialMediaType { get; set; }

        [JsonProperty("value")] public string Value { get; set; }
    }
}