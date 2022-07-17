using MongoDB.Driver;

namespace MakeItBuilderAspCore.Models.DatabaseEngine
{
    public interface IDbContext
    {
        IMongoDatabase GetDatabase();
    }
}