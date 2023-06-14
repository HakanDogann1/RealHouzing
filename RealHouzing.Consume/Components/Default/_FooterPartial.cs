using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.Components.Default
{
    public class _FooterPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
