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
            Console.WriteLine("Searching for test projects...");
            var testProjectPaths = context.ProjectDirectories
                .Where(x => x.EndsWith("Tests"))
                .ToList();
            Console.WriteLine($"{testProjectPaths.Count.ToString()} test project(s) discovered.");
            Console.WriteLine();
            
            foreach (var testProjectPath in testProjectPaths)
            {
                var projectName = testProjectPath.Split("/").Last();
                Console.WriteLine($"Running Test Project: {projectName}");
                Directory.SetCurrentDirectory(testProjectPath);
                context.DotNetCoreTool("fixie --no-build --framework net5.0");
            }
        }
    }
}