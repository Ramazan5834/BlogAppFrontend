using System.Threading.Tasks;
using BlogAppFrontend.ApiServices.Interfaces;
using BlogAppFrontend.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogAppFrontend.Controllers
{
    public class AccountController:Controller
    {
        private readonly IAuthApiService _authApiService;
        public AccountController(IAuthApiService authApiService)
        {
            _authApiService = authApiService;
        }

        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(AppUserLoginModel model)
        {
            if (await _authApiService.SignIn(model))
            {
                return RedirectToAction("Index","Blog",new{@area="Admin"});
            }
            return View();
        }
    }
}
