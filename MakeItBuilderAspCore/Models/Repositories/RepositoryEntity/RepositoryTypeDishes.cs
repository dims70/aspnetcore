using MakeItBuilderAspCore.Models.DatabaseEngine;
using MakeItBuilderAspCore.Models.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MakeItBuilderAspCore.Models.Repositories
{
    public class RepositoryTypeDishes:RepositoryCRUD<TypeDish>
    {
        private readonly IDbContext dbContext;

        public RepositoryTypeDishes(IDbContext dbContext) : base(nameCollection: "TypeDish", dbContext) 
            => this.dbContext = dbContext;
        public async Task<IEnumerable<TypeDish>> GetTypeDishesAsync()
        {
            var awaitTypeDish = await dbContext.GetDatabase()
                  .GetCollection<TypeDish>("TypeDish")
                  .FindAsync<TypeDish>(new BsonDocument() { });
            return awaitTypeDish.ToEnumerable();
        }
    }
}
