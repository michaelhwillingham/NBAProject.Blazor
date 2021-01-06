using System;
using System.Configuration;
using System.IO;
using Cake.Frosting;
using Newtonsoft.Json;

namespace Build.Tasks
{
    [TaskName("UpdateSettings")]
    [Dependency(typeof(Clean))]
    public class UpdateSettings : FrostingTask<BuildContext>
    {
        public override bool ShouldRun(BuildContext context)
        {
            return context.IsGitHubActions;
        }
        
        public override void Run(BuildContext context)
        {
            Console.WriteLine("Updating NBAProject.Tests/appsettings.json");
            Directory.SetCurrentDirectory("NBAProject.Tests");
            AddOrUpdateAppSetting("ApiSettings:BaseUrl", context.ApiBaseUrl);
            AddOrUpdateAppSetting("ApiSettings:Username", context.ApiUsername);
            AddOrUpdateAppSetting("ApiSettings:Password", context.ApiPassword);

            Console.WriteLine("Updating NBAProject.Blazor/appsettings.json");
            Directory.SetCurrentDirectory(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory())?.ToString()!,
                "NBAProject.Blazor"));
            AddOrUpdateAppSetting("ApiSettings:BaseUrl", context.ApiBaseUrl);
            AddOrUpdateAppSetting("ApiSettings:Username", context.ApiUsername);
            AddOrUpdateAppSetting("ApiSettings:Password", context.ApiPassword);
        }

        private static void AddOrUpdateAppSetting<T>(string key, T value)
        {
            try
            {
                var filePath = "appsettings.json";
                var jsonString = File.ReadAllText(filePath);
                dynamic jsonObj = JsonConvert.DeserializeObject(jsonString);

                var sectionPath = key.Split(":")[0];
                if (!string.IsNullOrEmpty(sectionPath))
                {
                    var keyPath = key.Split(":")[1];
                    if (jsonObj != null) jsonObj[sectionPath][keyPath] = value;
                }
                else if (jsonObj != null) jsonObj[sectionPath] = value;

                var output = JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
                File.WriteAllText(filePath, output);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings.");
            }
        }
    }
}