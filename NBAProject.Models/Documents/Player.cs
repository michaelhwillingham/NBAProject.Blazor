// ReSharper disable InconsistentNaming

using System;
using NBAProject.Infrastructure.Attributes;

namespace NBAProject.Models.Documents
{
    [BsonCollection("players")]
    public class Player : Document
    {
        public int PlayerID { get; set; }

        public string Status { get; set; }

        public int TeamID { get; set; }

        public string Team { get; set; }

        public int Jersey { get; set; }

        public string PositionCategory { get; set; }

        public string Position { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Height { get; set; }

        public int Weight { get; set; }

        public DateTime BirthDate { get; set; }

        public string College { get; set; }

        public string PhotoUrl { get; set; }

        public int? Experience { get; set; }

        public string InjuryStatus { get; set; }

        public int FanDuelPlayerID { get; set; }

        public int DraftKingsPlayerID { get; set; }

        public string FanDuelName { get; set; }

        public string DraftKingsName { get; set; }
    }
}