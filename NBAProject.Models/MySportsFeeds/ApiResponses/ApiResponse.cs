using System;
using Newtonsoft.Json;

namespace NBAProject.Models.MySportsFeeds.ApiResponses
{
    public abstract class ApiResponse
    {
        [JsonProperty("lastUpdatedOn")] public DateTimeOffset LastUpdatedOn { get; set; }
    }
}