using System;
using NBAProject.Models.MySportsFeeds.Other;
using NBAProject.Models.MySportsFeeds.Venue;
using Newtonsoft.Json;

namespace NBAProject.Models.MySportsFeeds.Team
{
    public class TeamDetails
    {
        [JsonProperty("id")] public long Id { get; set; }

        [JsonProperty("city")] public string City { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("abbreviation")] public string Abbreviation { get; set; }

        [JsonProperty("homeVenue")] public HomeVenue HomeVenue { get; set; }

        [JsonProperty("teamColoursHex")] public string[] TeamColoursHex { get; set; }

        [JsonProperty("socialMediaAccounts")] public SocialMediaAccount[] SocialMediaAccounts { get; set; }

        [JsonProperty("officialLogoImageSrc")] public Uri OfficialLogoImageSrc { get; set; }
    }
}