using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.Controllers
{
    public class ServiceHomePageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
