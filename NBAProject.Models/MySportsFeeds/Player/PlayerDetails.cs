using System;
using NBAProject.Models.MySportsFeeds.Enums;
using NBAProject.Models.MySportsFeeds.Other;
using NBAProject.Models.MySportsFeeds.Team;
using Newtonsoft.Json;

namespace NBAProject.Models.MySportsFeeds.Player
{
    public class PlayerDetails
    {
        [JsonProperty("id")] public long Id { get; set; }

        [JsonProperty("firstName")] public string FirstName { get; set; }

        [JsonProperty("lastName")] public string LastName { get; set; }

        [JsonProperty("primaryPosition")] public string PrimaryPosition { get; set; }

        [JsonProperty("alternatePositions")] public object[] AlternatePositions { get; set; }

        [JsonProperty("jerseyNumber")] public long? JerseyNumber { get; set; }

        [JsonProperty("currentTeam")] public TeamAsOfDate CurrentTeam { get; set; }

        [JsonProperty("currentRosterStatus")] public RosterStatus RosterStatus { get; set; }

        [JsonProperty("currentInjury")] public CurrentInjury CurrentInjury { get; set; }

        [JsonProperty("height")] public string Height { get; set; }

        [JsonProperty("weight")] public long? Weight { get; set; }

        [JsonProperty("birthDate")] public DateTimeOffset? BirthDate { get; set; }

        [JsonProperty("age")] public long? Age { get; set; }

        [JsonProperty("birthCity")] public string BirthCity { get; set; }

        [JsonProperty("birthCountry")] public string BirthCountry { get; set; }

        [JsonProperty("rookie")] public bool Rookie { get; set; }

        [JsonProperty("highSchool")] public string HighSchool { get; set; }

        [JsonProperty("college")] public string College { get; set; }

        [JsonProperty("handedness")] public Handedness Handedness { get; set; }

        [JsonProperty("officialImageSrc")] public Uri OfficialImageSrc { get; set; }

        [JsonProperty("socialMediaAccounts")] public SocialMediaAccount[] SocialMediaAccounts { get; set; }

        [JsonProperty("currentContractYear")] public object CurrentContractYear { get; set; }

        [JsonProperty("drafted")] public PlayerDraftInformation Drafted { get; set; }

        [JsonProperty("externalMappings")] public ExternalMapping[] ExternalMappings { get; set; }
    }
}