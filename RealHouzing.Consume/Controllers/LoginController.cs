using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.Consume.Models;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.Consume.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public LoginController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async  Task<IActionResult> Index(LoginViewModel model)
        {
            var value =await _signInManager.PasswordSignInAsync(model.UserName, model.Password,false,false);
            if(value.Succeeded)
            {
                return RedirectToAction("Index","About");
            }
            
            return View();
        }

        
    }
}
