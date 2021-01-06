using Newtonsoft.Json;

namespace NBAProject.Models.MySportsFeeds.Venue
{
    public class Venue
    {
        [JsonProperty("id")] public long Id { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("city")] public string City { get; set; }

        [JsonProperty("country")] public string Country { get; set; }

        [JsonProperty("geoCoordinates")] public GeoCoordinates GeoCoordinates { get; set; }

        [JsonProperty("capacitiesByEventType")]
        public CapacitiesByEventType[] CapacitiesByEventType { get; set; }

        [JsonProperty("playingSurface")] public string PlayingSurface { get; set; }

        [JsonProperty("baseballDimensions")] public object[] BaseballDimensions { get; set; }

        [JsonProperty("hasRoof")] public bool HasRoof { get; set; }

        [JsonProperty("hasRetractableRoof")] public bool HasRetractableRoof { get; set; }
    }
}