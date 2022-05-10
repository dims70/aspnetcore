using MakeItBuilderAspCore.Models.DatabaseEngine;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace MakeItBuilderAspCore.Models.Repositories
{
    public class RepositoryCRUD<Type>
    {
        private IMongoCollection<Type> _service;
        public RepositoryCRUD(string nameCollection) => _service = DbService.GetDatabase()
            .GetCollection<Type>(nameCollection);

        public async void Create(Type item) => await _service.InsertOneAsync(item);
        public async Task<Type> GetById(string objectId) => await _service
            .FindAsync(new BsonDocument("_id", objectId))
            .Result
            .FirstOrDefaultAsync();


        public void Update(ObjectId updateElement, Type newElement)
        {
        }
        public async void Delete(string deleteId) => await _service.
            DeleteOneAsync(new BsonDocument("_id",deleteId));
        
            //Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(deleteId)
    }
}
