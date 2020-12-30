// ReSharper disable InconsistentNaming

using NBAProject.Infrastructure.Attributes;

namespace NBAProject.Models.Documents
{
    [BsonCollection("playerSeasonStats")]
    public class PlayerSeasonStat : Document
    {
        public int StatID { get; set; }
        
        public int TeamID { get; set; }
        
        public int PlayerID { get; set; }
        
        public int SeasonType { get; set; }
        
        public int Season { get; set; }
        
        public string Name { get; set; }
        
        public string Team { get; set; }
        
        public string Position { get; set; }
        
        public int Started { get; set; }
        
        public int Games { get; set; }
        
        public decimal FantasyPoints { get; set; }
        
        public int Minutes { get; set; }
        
        public int Seconds { get; set; }
        
        public int FieldGoalsMade { get; set; }
        
        public int FieldGoalsAttempted { get; set; }

        public decimal FieldGoalsPercentage { get; set; }
        
        public int TwoPointersMade { get; set; }
        
        public int TwoPointersAttempted { get; set; }
        
        public decimal TwoPointersPercentage { get; set; }
        
        public int ThreePointersMade { get; set; }
        
        public int ThreePointersAttempted { get; set; }
        
        public decimal ThreePointersPercentage { get; set; }
        
        public int FreeThrowsMade { get; set; }
        
        public int FreeThrowsAttempted { get; set; }

        public decimal FreeThrowsPercentage { get; set; }
        
        public int OffensiveRebounds { get; set; }
        
        public int DefensiveRebounds { get; set; }
        
        public int Rebounds { get; set; }
        
        public int Assists { get; set; }
        
        public int Steals { get; set; }
        
        public int BlockedShots { get; set; }
        
        public int Turnovers { get; set; }
        
        public int PersonalFouls { get; set; }
        
        public int Points { get; set; }

        public decimal FantasyPointsFanDuel { get; set; }

        public decimal FantasyPointsDraftKings { get; set; }
        
        public int PlusMinus { get; set; }
        
        public int DoubleDoubles { get; set; }
        
        public int TripleDoubles { get; set; }
    }
}