using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeItBuilderAspCore.Models.DatabaseEngine
{
    public class DbService
    {
        public static IMongoDatabase GetDatabase()
        {


            var temp = new MongoClient(LoadMongoSettings());
                
            return temp.GetDatabase("bpfrghop0m2rico");
        }

        private static MongoClientSettings LoadMongoSettings()
        {
            string username = "ubi94eu279cgpxolusly";
            string password = "1Zo8haOeMi8IIZy7rEZs";
            string mongoDbAuthMechanism = "SCRAM-SHA-1";
            MongoInternalIdentity internalIdentity =
                      new MongoInternalIdentity("bpfrghop0m2rico", username);
            PasswordEvidence passwordEvidence = new PasswordEvidence(password);
            MongoCredential mongoCredential =
                 new MongoCredential(mongoDbAuthMechanism,
                         internalIdentity, passwordEvidence);
            List<MongoCredential> credentials =
                       new List<MongoCredential>() { mongoCredential };


            MongoClientSettings settings = new MongoClientSettings();
            // comment this line below if your mongo doesn't run on secured mode
            settings.Credentials = credentials;
            string mongoHost = "bpfrghop0m2rico-mongodb.services.clever-cloud.com";
            MongoServerAddress address = new MongoServerAddress(mongoHost);
            settings.Server = address;
            return settings;
        }
    }

}
