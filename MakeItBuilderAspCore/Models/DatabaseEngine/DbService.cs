using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace MakeItBuilderAspCore.Models.DatabaseEngine
{
    public class DbService : IDbContext
    {
        private readonly IConfiguration configuration;
        public DbService(IConfiguration configuration) 
            => this.configuration = configuration;
        public IMongoDatabase GetDatabase()
        {
            var settings = LoadMongoSettings();
            return new MongoClient(settings).GetDatabase(settings.Credential.Identity.Source);
        }

        private  MongoClientSettings LoadMongoSettings()
        {
            MongoSettings mongoSettings = new(configuration);

            MongoInternalIdentity internalIdentity = 
                new(mongoSettings.GetMongoDatabase(), mongoSettings.GetUsername());
            PasswordEvidence passwordEvidence = 
                new(mongoSettings.GetPassword());

            MongoClientSettings settings = new() {
                Credential = new MongoCredential(MongoSettings.AUTH_MECHANISM,
                         internalIdentity, passwordEvidence),
                Server = new MongoServerAddress(mongoSettings.GetMongoHost())
            };
            return settings;
        }
    }

}
