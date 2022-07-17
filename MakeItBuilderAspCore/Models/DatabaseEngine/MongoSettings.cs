using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeItBuilderAspCore.Models.DatabaseEngine
{
    public class MongoSettings
    {
        private string MongoHost { get; set; }
        private string MongoDatabase { get; set; }

        private string Username { get; set; }
        private string Password { get; set; }

        public const string AUTH_MECHANISM = "SCRAM-SHA-1";

        public MongoSettings(IConfiguration configuration)
        {
            MongoHost = configuration
                .GetSection("MongoSettings")
                .GetSection("MongoHost").Value;
            MongoDatabase = configuration
                .GetSection("MongoSettings")
                .GetSection("MongoDatabase").Value;
            Username = configuration
                .GetSection("MongoSettings")
                .GetSection("Username").Value;
            Password = configuration
                .GetSection("MongoSettings")
                .GetSection("Password").Value;
        }

        public string GetMongoHost() => MongoHost;
        public string GetMongoDatabase() => MongoDatabase;
        public string GetUsername() => Username;
        public string GetPassword() => Password;
    }
}
