using Newtonsoft.Json;

namespace NBAProject.Models.MySportsFeeds.Venue
{
    public class CapacitiesByEventType
    {
        [JsonProperty("eventType")] public string EventType { get; set; }

        [JsonProperty("capacity")] public long Capacity { get; set; }
    }
}