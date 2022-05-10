using MakeItBuilderAspCore.Models.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace MakeItBuilderAspCore.Models.Entities
{
    public static class Basket
    {
        public static List<Dish> dishes = new List<Dish>();
        public static void AddItemBasket(Dish dish) => dishes.Add(dish);

    }
}
