using System;
using NBAProject.Models.MySportsFeeds.Enums;
using Newtonsoft.Json;

namespace NBAProject.Models.MySportsFeeds.JsonConverters
{
    internal class ExternalMappingSourceConverter : JsonConverter
    {
        public static readonly ExternalMappingSourceConverter Singleton = new();

        public override bool CanConvert(Type t)
        {
            return t == typeof(ExternalMappingSource) || t == typeof(ExternalMappingSource?);
        }

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "DraftKings":
                    return ExternalMappingSource.DraftKings;
                case "FanDuel":
                    return ExternalMappingSource.FanDuel;
                case "FantasyDraft":
                    return ExternalMappingSource.FantasyDraft;
                case "Gracenote Sports":
                    return ExternalMappingSource.GracenoteSports;
                case "NBA.com":
                    return ExternalMappingSource.NbaCom;
                case "RotoGrinders":
                    return ExternalMappingSource.RotoGrinders;
                case "Yahoo":
                    return ExternalMappingSource.Yahoo;
            }

            throw new Exception("Cannot unmarshal type ExternalMappingSource");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (ExternalMappingSource) untypedValue;
            switch (value)
            {
                case ExternalMappingSource.DraftKings:
                    serializer.Serialize(writer, "DraftKings");
                    return;
                case ExternalMappingSource.FanDuel:
                    serializer.Serialize(writer, "FanDuel");
                    return;
                case ExternalMappingSource.FantasyDraft:
                    serializer.Serialize(writer, "FantasyDraft");
                    return;
                case ExternalMappingSource.GracenoteSports:
                    serializer.Serialize(writer, "Gracenote Sports");
                    return;
                case ExternalMappingSource.NbaCom:
                    serializer.Serialize(writer, "NBA.com");
                    return;
                case ExternalMappingSource.RotoGrinders:
                    serializer.Serialize(writer, "RotoGrinders");
                    return;
                case ExternalMappingSource.Yahoo:
                    serializer.Serialize(writer, "Yahoo");
                    return;
            }

            throw new Exception("Cannot marshal type ExternalMappingSource");
        }
    }
}