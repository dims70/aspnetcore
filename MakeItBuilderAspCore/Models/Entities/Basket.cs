using MakeItBuilderAspCore.Models.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace MakeItBuilderAspCore.Models.Entities
{
    public static class Basket
    {
        public static List<Dish> dishes = new List<Dish>();

        public static Dictionary<string, int> countDish = new Dictionary<string, int>();
        public static void AddItemBasket(Dish dish, int count)
        {
            dishes.Add(dish);
            countDish.Add(dish._id, count);
        }

        public static void DeleteItemBasket(Dish dish)
        {
            dishes.Remove(dish);
            countDish.Remove(dish._id);
        }

        public static int GetCountItemBasket() 
            => dishes.Count();
    }
}
