using MakeItBuilderAspCore.Models.ViewModels;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using MakeItBuilderAspCore.Models.Repositories.RepositoryEntity;

namespace MakeItBuilderAspCore.Controllers.Admin
{
    [Authorize] 
    public class AdminController : Controller
    { 
        private readonly RepositoryUsers _repositoryUsers;
        public AdminController(RepositoryUsers repositoryUsers)
        {
            _repositoryUsers = repositoryUsers;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Settings()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login(string ReturnUrl)
        {   
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginViewModel loginModel)
        {   
            if (loginModel != null)
            {
                var user = await _repositoryUsers.GetUserAuth(loginModel.Login, loginModel.Password);
                if (user != null)
                {
                    await Authenticate(user.Login);
                    return StatusCode(202);
                }
            }
            return StatusCode(401);
        }

        public async Task Authenticate(string login)
        {
            List<Claim> claims = new ()
            {
                new (ClaimsIdentity.DefaultNameClaimType, login)
            };

            ClaimsIdentity id = new (claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new (id));
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Admin");
        }
    }
}
