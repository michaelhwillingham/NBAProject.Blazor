using System;
using NBAProject.Models.MySportsFeeds.Enums;
using Newtonsoft.Json;

namespace NBAProject.Models.MySportsFeeds.JsonConverters
{
    internal class CurrentRosterStatusConverter : JsonConverter
    {
        public static readonly CurrentRosterStatusConverter Singleton = new();

        public override bool CanConvert(Type t)
        {
            return t == typeof(RosterStatus) || t == typeof(RosterStatus?);
        }

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "ASSIGNED_TO_MINORS":
                    return RosterStatus.AssignedToMinors;
                case "RETIRED":
                    return RosterStatus.Retired;
                case "ROSTER":
                    return RosterStatus.Roster;
                case "UFA":
                    return RosterStatus.Ufa;
            }

            throw new Exception("Cannot unmarshal type CurrentRosterStatus");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (RosterStatus) untypedValue;
            switch (value)
            {
                case RosterStatus.AssignedToMinors:
                    serializer.Serialize(writer, "ASSIGNED_TO_MINORS");
                    return;
                case RosterStatus.Retired:
                    serializer.Serialize(writer, "RETIRED");
                    return;
                case RosterStatus.Roster:
                    serializer.Serialize(writer, "ROSTER");
                    return;
                case RosterStatus.Ufa:
                    serializer.Serialize(writer, "UFA");
                    return;
            }

            throw new Exception("Cannot marshal type CurrentRosterStatus");
        }
    }
}