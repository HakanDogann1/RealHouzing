using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.Components.Default
{
    public class _HeadPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
