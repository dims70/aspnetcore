using MakeItBuilderAspCore.Models;
using MakeItBuilderAspCore.Models.Repositories;
using MakeItBuilderAspCore.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MakeItBuilderAspCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly RepositoryTypeDishes _typeDishes;
        private readonly RepositoryStock _stock;
        private readonly RepositoryDishes _dishes;

        public HomeController(RepositoryTypeDishes typeDishes, RepositoryStock stock, RepositoryDishes dishes) {
            _typeDishes = typeDishes;
            _stock = stock;
            _dishes = dishes;
        }
        public IActionResult Index() => View(new IndexViewModel(_typeDishes, _dishes));
        ////public async Task<IActionResult> Index() => View((await _typeDishes.GetTypeDishes(), await Task.Run(() => _dishes.GetDishes()
        ////  .Result
        ////  .Where(x => x.typeDish == "61e52ffad095affaabdf78d8").ToList())));
        #region TEST
        //[HttpPost]
        //public IActionResult DeleteDishes(RepositoryDishes repositoryDishes,string id)
        //{
        //    if (string.IsNullOrEmpty(id))
        //    {
        //        return StatusCode(400);
        //    }
        //    repositoryDishes.Delete(id);
        //    return Ok();
        //}
        #endregion
        public async Task<IActionResult> Stocks() => View(await _stock.GetStocks());
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult TermsDelivery() => View();
        public IActionResult Basket() => View();
            

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
