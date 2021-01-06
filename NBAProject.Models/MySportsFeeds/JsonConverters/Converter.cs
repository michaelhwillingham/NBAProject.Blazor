using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NBAProject.Models.MySportsFeeds.JsonConverters
{
    public static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new()
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                PlayingProbabilityConverter.Singleton,
                CurrentRosterStatusConverter.Singleton,
                TeamAbbreviationConverter.Singleton,
                ExternalMappingSourceConverter.Singleton,
                ShootsConverter.Singleton,
                new IsoDateTimeConverter {DateTimeStyles = DateTimeStyles.AssumeUniversal}
            }
        };
    }
}