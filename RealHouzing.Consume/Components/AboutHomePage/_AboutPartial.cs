using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models;

namespace RealHouzing.Consume.Components.AboutHomePage
{
    public class _AboutPartial:ViewComponent
    {
      
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
