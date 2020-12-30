using Cake.Common;
using Cake.Core;
using Cake.Frosting;

namespace Build
{
    public class BuildContext : FrostingContext
    {
        public BuildContext(ICakeContext context) : base(context)
        {
            MsBuildConfiguration = context.Argument("configuration", "Debug");
            MongoConnectionString = context.Argument("mongoConnectionString", "mongodb://localhost:27017");
            MongoDevDatabaseName = context.Argument("mongoDevDatabaseName", "nbaprojectblazor-db-DEV");
            MongoTestDatabaseName = context.Argument("mongoTestDatabaseName", "nbaprojectblazor-db-TEST");
            MongoProdDatabaseName = context.Argument("mongoProdDatabaseName", "nbaprojectblazor-db-PROD");
            IsGitHubActions = context.Argument("isGitHubActions", false);
        }

        public string MsBuildConfiguration { get; }
        public string MongoConnectionString { get; }
        public string MongoDevDatabaseName { get; }
        public string MongoTestDatabaseName { get; }
        public string MongoProdDatabaseName { get; }
        public bool IsGitHubActions { get; }
    }
}