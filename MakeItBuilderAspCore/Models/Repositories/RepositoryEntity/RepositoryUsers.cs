using MakeItBuilderAspCore.Models.DatabaseEngine;
using MakeItBuilderAspCore.Models.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeItBuilderAspCore.Models.Repositories.RepositoryEntity
{
    public class RepositoryUsers : RepositoryCRUD<User>
    {   
        private readonly IDbContext dbService;
        public RepositoryUsers(IDbContext dbService) : base("User", dbService)
        {
            this.dbService = dbService;
        }
        public async Task<int> GetUserCountAsync()
        { 
            var awaitCount = await dbService.GetDatabase()
                          .GetCollection<User>("User")
                          .FindAsync<User>(new BsonDocument());
            return awaitCount.ToEnumerable().Count();
        }
        public async Task<User> GetUserAuth(string Login, string Password)
        { 
            var user = await dbService.GetDatabase()
                          .GetCollection<User>("User")
                          .FindAsync<User>(new BsonDocument("$and", new BsonArray() {
                           new BsonDocument("Login",Login),
                           new BsonDocument("Password",Password)
                          }));
            return await user.FirstOrDefaultAsync();
        }
    }
}
