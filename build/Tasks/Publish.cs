using System;
using System.IO;
using System.Linq;
using Cake.Common.Tools.DotNetCore;
using Cake.Common.Tools.DotNetCore.Publish;
using Cake.Frosting;

namespace Build.Tasks
{
    [TaskName("Publish")]
    [Dependency(typeof(Test))]
    public sealed class Publish : FrostingTask<BuildContext>
    {
        public override bool ShouldRun(BuildContext context) 
            => context.MsBuildConfiguration == "Release";

        public override void Run(BuildContext context)
        {
            var projectDirectory = Directory
                .GetDirectories(Directory.GetCurrentDirectory()).SingleOrDefault(x =>
                    Enumerable.Last<string>(x.Split("/")).Equals("NBAProject.Blazor"));
            Console.WriteLine($"Project path: {projectDirectory}");
            
            Console.WriteLine("Publishing NBAProject.Blazor");
            context.DotNetCorePublish($"{projectDirectory}/NBAProject.Blazor.csproj", new DotNetCorePublishSettings
            {
                Configuration = context.MsBuildConfiguration,
                NoBuild = true,
                NoRestore = true,
                NoLogo = true,
                OutputDirectory = $"{Directory.GetCurrentDirectory()}/release"
            });
        }
    }
}