using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace MakeItBuilderAspCore.Models.Entities
{
    public class Stock
    {   [BsonId]
        public ObjectId _id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public string urlToImg { get; set; }
        [Required]
        public string dateExp { get; set; }
    }
}
