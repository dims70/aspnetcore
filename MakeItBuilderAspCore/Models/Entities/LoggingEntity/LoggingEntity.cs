using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MakeItBuilderAspCore.Models.LoggingEntity
{
    public class LoggingEntity
    {   [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        [Required]
        [Display(Name ="Идентификатор")]
        public string Identify { get; set; }
        [Required]
        [Display(Name ="IP Адрес")]
        public string IpRequest { get; set; }
    }
}
