using System;
using System.IO;
using System.Linq;
using Cake.Common.Tools.DotNetCore;
using Cake.Common.Tools.DotNetCore.Test;
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
                .Where(x => x.Split("/").Last().EndsWith("Test"))
                .ToList();
            Console.WriteLine($"{projects.Count.ToString()} test project(s) discovered.");
            Console.WriteLine();

            foreach (var project in projects)
            {
                context.DotNetCoreTest(project, new DotNetCoreTestSettings
                {
                    NoBuild = true,
                    NoLogo = true,
                    NoRestore = true
                });
            }

            Directory.SetCurrentDirectory("..");
        }
    }
}