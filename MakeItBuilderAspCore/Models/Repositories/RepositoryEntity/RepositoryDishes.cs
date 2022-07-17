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
        private readonly IDbContext dbService;

        public RepositoryDishes(IDbContext dbService) : base(nameCollection:"Dish",dbService) 
        {
            this.dbService = dbService;
        }
        public async Task<IEnumerable<Dish>> GetDishesAsync()
        { 
            var awaitDishes = await dbService.GetDatabase()
                          .GetCollection<Dish>("Dish")
                          .FindAsync<Dish>(new BsonDocument() { });
            return awaitDishes.ToEnumerable();
        }
    }
}
