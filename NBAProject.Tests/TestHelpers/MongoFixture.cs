using System.IO;
using Microsoft.Extensions.Configuration;
using NBAProject.Models.Documents;
using NBAProject.Services.MongoDb;

namespace NBAProject.Tests.TestHelpers
{
    public class MongoFixture<TDocument> where TDocument : IDocument
    {
        public MongoFixture()
        {
            var appSettings = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            var config = new ConfigurationBuilder()
                .AddJsonFile(appSettings)
                .Build();

            var mongoDbSettings = config.GetSection("MongoDbSettings");
            var connectionString = mongoDbSettings.GetSection("ConnectionString").Value;
            var databaseName = mongoDbSettings.GetSection("DatabaseName").Value;

            MongoDbSettings = new MongoDbSettings
            {
                ConnectionString = connectionString,
                DatabaseName = databaseName
            };

            MongoRepository = new MongoRepository<TDocument>(MongoDbSettings);
        }

        public IMongoDbSettings MongoDbSettings { get; }
        public IMongoRepository<TDocument> MongoRepository { get; }
    }
}