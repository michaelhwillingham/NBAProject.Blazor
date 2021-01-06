using System;
using NBAProject.Models.MySportsFeeds.Enums;
using Newtonsoft.Json;

namespace NBAProject.Models.MySportsFeeds.JsonConverters
{
    internal class ShootsConverter : JsonConverter
    {
        public static readonly ShootsConverter Singleton = new();

        public override bool CanConvert(Type t)
        {
            return t == typeof(Shoots) || t == typeof(Shoots?);
        }

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "L":
                    return Shoots.Left;
                case "R":
                    return Shoots.Right;
            }

            throw new Exception("Cannot unmarshal type Shoots");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (Shoots) untypedValue;
            switch (value)
            {
                case Shoots.Left:
                    serializer.Serialize(writer, "L");
                    return;
                case Shoots.Right:
                    serializer.Serialize(writer, "R");
                    return;
            }

            throw new Exception("Cannot marshal type Shoots");
        }
    }
}