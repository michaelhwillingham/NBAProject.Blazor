using System;
using System.IO;
using System.Linq;
using Cake.Common.IO;
using Cake.Frosting;

namespace Build.Tasks
{
    [TaskName("Clean")]
    public sealed class Clean : FrostingTask<BuildContext>
    {
        public override void Run(BuildContext context)
        {
            Console.WriteLine("Searching for projects...");
            var projects = Directory.GetDirectories(Directory.GetCurrentDirectory())
                .Where(x => x.Split("/").Last().StartsWith("NBAProject"))
                .ToList();
            Console.WriteLine($"{projects.Count.ToString()} project(s) discovered.");
            Console.WriteLine();

            foreach (var project in projects)
            {
                Console.WriteLine($"Project: {project.Split("/").Last()}");
                Console.WriteLine($"Cleaning directory: {project}/bin");
                context.CleanDirectory($"{project}/bin");
                Console.WriteLine($"Cleaning directory: {project}/obj");
                context.CleanDirectory($"{project}/obj");
                Console.WriteLine();
            }
        }
    }
}