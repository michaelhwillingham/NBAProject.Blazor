using Newtonsoft.Json;

namespace NBAProject.Models.MySportsFeeds.Venue
{
    public class GeoCoordinates
    {
        [JsonProperty("latitude")] public decimal Latitude { get; set; }

        [JsonProperty("longitude")] public decimal Longitude { get; set; }
    }
}