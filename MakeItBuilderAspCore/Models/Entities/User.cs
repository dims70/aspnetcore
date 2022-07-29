using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MakeItBuilderAspCore.Models.Entities
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        public string Login { get; set; }
        public string Password { get; set; }
    }
}
