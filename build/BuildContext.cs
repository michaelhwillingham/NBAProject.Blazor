using Cake.Common;
using Cake.Core;
using Cake.Frosting;

namespace Build
{
    public abstract class BuildContext : FrostingContext
    {
        public string MsBuildConfiguration { get; set; }

        public BuildContext(ICakeContext context) 
            : base(context)
        {
            MsBuildConfiguration = context.Argument("configuration", "Debug");
        }
    }
}