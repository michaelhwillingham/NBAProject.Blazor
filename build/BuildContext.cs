using System.Collections.Generic;
using System.IO;
using System.Linq;
using Cake.Common;
using Cake.Core;
using Cake.Frosting;

namespace Build
{
    public class BuildContext : FrostingContext
    {
        public string MsBuildConfiguration { get; set; }
        public IEnumerable<string> ProjectDirectories { get; set; }
    
        public BuildContext(ICakeContext context) 
            : base(context)
        {
            MsBuildConfiguration = context.Argument("configuration", "Debug");
        }
    }
}