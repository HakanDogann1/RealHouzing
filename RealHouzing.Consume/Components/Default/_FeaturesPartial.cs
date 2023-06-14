using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.Components.Default
{
    public class _FeaturesPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
