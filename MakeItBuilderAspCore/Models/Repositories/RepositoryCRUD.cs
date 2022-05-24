using MakeItBuilderAspCore.Models.DatabaseEngine;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MakeItBuilderAspCore.Models.Repositories
{
    public class RepositoryCRUD<Type>
    {
        private IMongoCollection<Type> _service;
        public RepositoryCRUD(string nameCollection) => _service = DbService.GetDatabase()
            .GetCollection<Type>(nameCollection);

        public async void CreateAsync(Type item) 
            => await _service.InsertOneAsync(item);

        public async Task<Type> GetById(string objectId) => await _service
            .FindAsync(new BsonDocument("_id", objectId))
            .Result
            .FirstOrDefaultAsync();

        public async Task<IEnumerable<Type>> GetCollectionEntity()
        {
            IAsyncCursor<Type> entities = await _service
                .FindAsync(new BsonDocument());
            return entities.ToEnumerable();
}

        public void UpdateAsync(ObjectId updateElement, Type newElement)
        {
        }
        public async void DeleteAsync(string deleteId) => await _service.
            DeleteOneAsync(new BsonDocument("_id",deleteId));
        
            //Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(deleteId)
    }
}
