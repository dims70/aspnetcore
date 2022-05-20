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
    public class RepositoryStock : RepositoryCRUD<Stock>
    {
        public RepositoryStock() : base(nameCollection: "Stock") {/*пустой*/}
        public async Task<List<Stock>> GetStocks() => await DbService.GetDatabase()
            .GetCollection<Stock>("Stock")
            .FindAsync<Stock>(new BsonDocument() { }).Result.ToListAsync();
    }
}
