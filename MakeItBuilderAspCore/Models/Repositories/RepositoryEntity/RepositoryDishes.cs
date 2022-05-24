using MakeItBuilderAspCore.Models.DatabaseEngine;
using MakeItBuilderAspCore.Models.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MakeItBuilderAspCore.Models.Repositories
{

    public class RepositoryDishes : RepositoryCRUD<Dish>
    {
        public RepositoryDishes() : base(nameCollection:"Dish") {/*пустой*/}
        public async Task<IEnumerable<Dish>> GetDishesAsync()
        { var awaitDishes = await DbService.GetDatabase()
                          .GetCollection<Dish>("Dish")
                          .FindAsync<Dish>(new BsonDocument() { });
            return awaitDishes.ToEnumerable();
        }
    }
}
