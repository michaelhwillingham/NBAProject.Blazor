using System;
using System.IO;
using System.Linq;
using Cake.Common.Tools.DotNetCore;
using Cake.Frosting;

namespace Build.Tasks
{
    [TaskName("Test")]
    [Dependency(typeof(Build))]
    public sealed class Test : FrostingTask<BuildContext>
    {
        public override void Run(BuildContext context)
        {
            var projects = Directory.GetDirectories(Directory.GetCurrentDirectory())
                .Where(x => x.Split("/").Last().EndsWith("Tests"))
                .ToList();
            Console.WriteLine($"{projects.Count.ToString()} test project(s) discovered.");
            Console.WriteLine();

            foreach (var project in projects)
            {
                Console.WriteLine($"Navigating to directory {project}");
                var projectName = project.Split("/").Last();
                Directory.SetCurrentDirectory($"{Directory.GetCurrentDirectory()}/{projectName}");

                context.DotNetCoreTool(
                    $"fixie --configuration {context.MsBuildConfiguration} --no-build --framework net5.0");
                Console.WriteLine();
            }

            Directory.SetCurrentDirectory("..");
        }
    }
}