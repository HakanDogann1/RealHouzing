using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.Components.Default
{
    public class _TestimonialsPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
