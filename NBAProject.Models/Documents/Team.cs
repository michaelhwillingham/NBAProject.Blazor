// ReSharper disable InconsistentNaming

using NBAProject.Infrastructure.Attributes;

namespace NBAProject.Models.Documents
{
    [BsonCollection("teams")]
    public class Team : Document
    {
        public int TeamID { get; set; }

        public string Key { get; set; }

        public bool Active { get; set; }

        public string City { get; set; }

        public string Name { get; set; }

        public int LeagueID { get; set; }

        public int StadiumID { get; set; }

        public string Conference { get; set; }

        public string Division { get; set; }

        public string PrimaryColor { get; set; }

        public string SecondaryColor { get; set; }

        public string TertiaryColor { get; set; }

        public string QuaternaryColor { get; set; }

        public string WikipediaLogoUrl { get; set; }

        public string WikipediaWordMarkUrl { get; set; }
    }
}