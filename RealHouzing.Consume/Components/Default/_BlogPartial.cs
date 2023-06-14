using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.Components.Default
{
    public class _BlogPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
