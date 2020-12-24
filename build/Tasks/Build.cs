using System;
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
            foreach (var projectPath in context.ProjectDirectories)
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