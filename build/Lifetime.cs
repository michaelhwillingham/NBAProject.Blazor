using System.IO;
using System.Linq;
using Cake.Common.Diagnostics;
using Cake.Core;
using Cake.Frosting;

namespace Build
{
    public sealed class Lifetime : FrostingLifetime<BuildContext>
    {
        public override void Setup(BuildContext context)
        {
            context.Information("Setting things up...");
            context.ProjectDirectories = Directory.GetDirectories(Directory.GetCurrentDirectory())
                .Where(x => x.Split("/").Last().StartsWith("NBAProject"));
        }

        public override void Teardown(BuildContext context, ITeardownContext info)
        {
            context.Information("Tearing things down...");
        }
    }
}