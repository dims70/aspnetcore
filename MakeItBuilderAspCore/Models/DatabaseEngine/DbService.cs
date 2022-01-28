using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeItBuilderAspCore.Models.DatabaseEngine
{
    public class DbService
    {
        public static IMongoDatabase GetDatabase() => new MongoClient("mongodb://localhost:27017/").GetDatabase("MakeItBuilderDb");
    }

}
