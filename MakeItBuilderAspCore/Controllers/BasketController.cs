using MakeItBuilderAspCore.Models.Entities;
using MakeItBuilderAspCore.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeItBuilderAspCore.Controllers
{
    public class BasketController : Controller
    {   //Repositories
        public RepositoryDishes repositoryDishes { get; set; }
        public ILogger<BasketController> Logger { get; }

        public BasketController(RepositoryDishes repositoryDishes, ILogger<BasketController> logger)
        {
            this.repositoryDishes = repositoryDishes;
            Logger = logger;
        }
        //Получение кол-ва товаров в корзине
        [HttpGet]
        public IActionResult GetCountBasket() => new JsonResult(Basket.dishes.Count);
        
        //Добавление товара в корзину
        public async Task<IActionResult> AddDishBasket(string id, int count)
        {
            Basket.AddItemBasket((await repositoryDishes
            .GetDishesAsync())
            .SingleOrDefault(x => x._id == id), count);
            return Ok();
        }
        //Удаление из корзины
        [HttpPost]
        [Consumes("application/json")]
        public IActionResult DeleteDishBasket([FromBody] JObject id)
        {
            //Logger.LogInformation();
            Basket.dishes.RemoveAll(x => x._id == (id.Properties().Select(x => x.Value).FirstOrDefault().ToString()));
            return Ok();
        }
    }
}
