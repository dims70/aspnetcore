using MakeItBuilderAspCore.Models.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace MakeItBuilderAspCore.Models.Entities
{
    public class Dish
    {   [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        [Display(Name="Наименование")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Описание")]
        [Required]
        public string Description { get; set; }
        [Display(Name = "Вес")]
        [Required]
        public int Weight { get; set; }
        [Display(Name = "Белки")]
        [Required]
        public double Protein { get; set; }
        [Display(Name = "Жиры")]
        [Required]
        public double Fats { get; set; }
        [Display(Name = "Углеводы")]
        [Required]
        public double Carbohydrates { get; set; }
        [Display(Name = "Ккал")]
        [Required]
        public int Kcal { get; set; }
        [Display(Name = "Цена")]
        [Required]
        public decimal Price { get; set; }

        public string urlToImg { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        public string typeDish { get; set; }
    }
    }
