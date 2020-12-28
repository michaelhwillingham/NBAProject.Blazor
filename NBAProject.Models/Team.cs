// ReSharper disable InconsistentNaming
using Newtonsoft.Json;

namespace NBAProject.Models
{
    [JsonObject]
    public class Team
    {
        public int TeamID { get; set; }

        public string Key { get; set; }

        public string City { get; set; }
        
        public string Name { get; set; }
        
        public string Conference { get; set; }
        
        public string Division { get; set; }
        
        public string PrimaryColor { get; set; }
        
        public string SecondaryColor { get; set; }
        
        public string TertiaryColor { get; set; }
        
        public string QuaternaryColor { get; set; }
        
        public string WikipediaLogoUrl { get; set; }
    }
}