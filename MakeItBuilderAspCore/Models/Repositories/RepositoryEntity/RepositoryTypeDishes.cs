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
        public RepositoryTypeDishes():base(nameCollection:"TypeDish"){/*пустой*/}
        public async Task<IEnumerable<TypeDish>> GetTypeDishesAsync()
        {
            var awaitTypeDish = await DbService.GetDatabase()
                  .GetCollection<TypeDish>("TypeDish")
                  .FindAsync<TypeDish>(new BsonDocument() { });
            return awaitTypeDish.ToEnumerable();
        }
    }
}
