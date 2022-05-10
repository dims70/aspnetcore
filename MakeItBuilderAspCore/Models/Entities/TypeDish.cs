using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace MakeItBuilderAspCore.Models.Entities
{
    public class TypeDish
    {   [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        [Display(Name = "Тип блюда")]
        public string nameType { get; set; }
    }
}
