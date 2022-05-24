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
        public RepositoryStock() : base(nameCollection: "Stock") {/*пустой*/}
        public async Task<List<Stock>> GetStocks() => await DbService.GetDatabase()
            .GetCollection<Stock>("Stock")
            .FindAsync<Stock>(new BsonDocument() { }).Result.ToListAsync();
    }
}
