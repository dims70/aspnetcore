using MakeItBuilderAspCore.Models.DatabaseEngine;
using MakeItBuilderAspCore.Models.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MakeItBuilderAspCore.Models.Repositories
{
    public class RepositoryStock : RepositoryCRUD<Stock>
    {
        private readonly IDbContext dbContext;

        public RepositoryStock(IDbContext dbContext) : base(nameCollection: "Stock", dbContext) 
            => this.dbContext = dbContext;
        public async Task<List<Stock>> GetStocks() => await dbContext.GetDatabase()
            .GetCollection<Stock>("Stock")
            .FindAsync<Stock>(new BsonDocument() { }).Result.ToListAsync();
    }
}
