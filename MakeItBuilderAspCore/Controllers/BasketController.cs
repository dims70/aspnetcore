using MakeItBuilderAspCore.Models.Entities;
using MakeItBuilderAspCore.Models.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeItBuilderAspCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        public RepositoryDishes repositoryDishes { get; set; }
        public ILogger<BasketController> Logger { get; }

        public BasketController(RepositoryDishes repositoryDishes, ILogger<BasketController> logger)
        {
            this.repositoryDishes = repositoryDishes;
            Logger = logger;
        }

        [HttpGet]
        public IActionResult Get() => new JsonResult(Basket.dishes.Count);
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            Basket.AddItemBasket((await repositoryDishes
            .GetDishesAsync())
            .SingleOrDefault(x => x._id == id));
            return Ok();
        }
        [HttpPost]
        [Consumes("application/json")]
        public IActionResult PostDelete([FromBody]JObject id)
        {
            //Logger.LogInformation();
            Basket.dishes.RemoveAll(x => x._id == (id.Properties().Select(x=>x.Value).FirstOrDefault().ToString()));
            return Ok();
        }
    }
}
