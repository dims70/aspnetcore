using MakeItBuilderAspCore.Models.Entities;
using MakeItBuilderAspCore.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeItBuilderAspCore.Models.ViewModels
{
    public class IndexViewModel
    {

        public IEnumerable<TypeDish> TypeDishes { get; set; }

        public IEnumerable<Dish> Dishes { get; set; }

        public  IndexViewModel(RepositoryTypeDishes _typeDishes, RepositoryDishes _dishes)
        {
            TypeDishes = InitTypeDishes(_typeDishes).Result;
            Dishes = InitDishes(_dishes).Result;
        }

        private async Task<IEnumerable<Dish>> InitDishes(RepositoryDishes _dishes) 
            => await _dishes.GetDishesAsync();

        private async Task<IEnumerable<TypeDish>> InitTypeDishes(RepositoryTypeDishes _typeDishes) 
            => await _typeDishes.GetTypeDishesAsync();
    }
}
