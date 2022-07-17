using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MakeItBuilderAspCore.Controllers.Admin
{
    [Authorize]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Settings()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Login(string ReturnUrl)
        {
            return View();
        }
    }
}
