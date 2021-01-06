using NBAProject.Models.MySportsFeeds.Enums;
using Newtonsoft.Json;

namespace NBAProject.Models.MySportsFeeds.Other
{
    public class ExternalMapping
    {
        [JsonProperty("source")] public ExternalMappingSource Source { get; set; }

        [JsonProperty("id")] public object Id { get; set; }
    }
}