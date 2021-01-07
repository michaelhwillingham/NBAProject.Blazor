using Cake.Common;
using Cake.Core;
using Cake.Frosting;

namespace Build
{
    public class BuildContext : FrostingContext
    {
        public BuildContext(ICakeContext context) : base(context)
        {
            MsBuildConfiguration = context.Argument("configuration", "Debug");
        }

        public string MsBuildConfiguration { get; }
    }
}