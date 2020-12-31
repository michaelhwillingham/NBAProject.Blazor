// ReSharper disable InconsistentNaming

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using NBAProject.Infrastructure.Attributes;

namespace NBAProject.Models.Documents
{
    [BsonCollection("standings")]
    public class Standing : Document
    {
        public int Season { get; set; }

        public int SeasonType { get; set; }

        public int TeamID { get; set; }

        public string Key { get; set; }

        public string City { get; set; }

        public string Name { get; set; }

        public string Conference { get; set; }

        public string Division { get; set; }

        public int Wins { get; set; }

        public int Losses { get; set; }

        [BsonRepresentation(BsonType.Decimal128, AllowTruncation = true)]
        public decimal Percentage { get; set; }

        public int ConferenceWins { get; set; }

        public int ConferenceLosses { get; set; }

        public int DivisionWins { get; set; }

        public int DivisionLosses { get; set; }

        public int HomeWins { get; set; }

        public int HomeLosses { get; set; }

        public int AwayWins { get; set; }

        public int AwayLosses { get; set; }

        public int LastTenWins { get; set; }

        public int LastTenLosses { get; set; }

        public decimal PointsPerGameFor { get; set; }

        public decimal PointsPerGameAgainst { get; set; }

        public int Streak { get; set; }

        public double GamesBack { get; set; }

        public string StreakDescription { get; set; }

        public int GlobalTeamID { get; set; }

        public int? ConferenceRank { get; set; }

        public int? DivisionRank { get; set; }
    }
}