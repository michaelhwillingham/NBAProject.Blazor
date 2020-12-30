using System;
using System.IO;
using System.Linq;
using Cake.Common.Tools.DotNetCore;
using Cake.Common.Tools.DotNetCore.Build;
using Cake.Frosting;

namespace Build.Tasks
{
    [TaskName("Build")]
    [Dependency(typeof(UpdateSettings))]
    public sealed class Build : FrostingTask<BuildContext>
    {
        public override void Run(BuildContext context)
        {
            Directory.SetCurrentDirectory(Directory.GetParent(Directory.GetCurrentDirectory())?.ToString()!);

            var projectDirectories = Directory.GetDirectories(Directory.GetCurrentDirectory())
                .Where(x => x.Split("/").Last().StartsWith("NBAProject"));

            foreach (var projectPath in projectDirectories)
            {
                var projectName = projectPath.Split("/").Last();
                Console.WriteLine($"Building Project: {projectName}");
                context.DotNetCoreBuild($"{projectName}/{projectName}.csproj", new DotNetCoreBuildSettings
                {
                    Configuration = context.MsBuildConfiguration
                });
                Console.WriteLine();
            }
        }
    }
}