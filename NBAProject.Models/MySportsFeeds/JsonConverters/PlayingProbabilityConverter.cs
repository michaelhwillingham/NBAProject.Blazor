using System;
using NBAProject.Models.MySportsFeeds.Enums;
using Newtonsoft.Json;

namespace NBAProject.Models.MySportsFeeds.JsonConverters
{
    internal class PlayingProbabilityConverter : JsonConverter
    {
        public static readonly PlayingProbabilityConverter Singleton = new();

        public override bool CanConvert(Type t)
        {
            return t == typeof(PlayingProbability) || t == typeof(PlayingProbability?);
        }

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "DOUBTFUL":
                    return PlayingProbability.Doubtful;
                case "OUT":
                    return PlayingProbability.Out;
                case "PROBABLE":
                    return PlayingProbability.Probable;
                case "QUESTIONABLE":
                    return PlayingProbability.Questionable;
            }

            throw new Exception("Cannot unmarshal type PlayingProbability");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (PlayingProbability) untypedValue;
            switch (value)
            {
                case PlayingProbability.Doubtful:
                    serializer.Serialize(writer, "DOUBTFUL");
                    return;
                case PlayingProbability.Out:
                    serializer.Serialize(writer, "OUT");
                    return;
                case PlayingProbability.Probable:
                    serializer.Serialize(writer, "PROBABLE");
                    return;
                case PlayingProbability.Questionable:
                    serializer.Serialize(writer, "QUESTIONABLE");
                    return;
            }

            throw new Exception("Cannot marshal type PlayingProbability");
        }
    }
}