using System;
using System.IO;
using System.Linq;
using Cake.Common.Tools.DotNetCore;
using Cake.Common.Tools.DotNetCore.Build;
using Cake.Frosting;

namespace Build.Tasks
{
    [TaskName("Build")]
    [Dependency(typeof(Clean))]
    public sealed class Build : FrostingTask<BuildContext>
    {
        public override void Run(BuildContext context)
        {
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