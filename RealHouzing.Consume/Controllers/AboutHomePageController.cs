using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.Controllers
{
    public class AboutHomePageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
