using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models;

namespace RealHouzing.Consume.Components.AboutHomePage
{
    
    public class _AboutService1Partial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AboutService1Partial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync(AboutService1ListViewModel model)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44373/api/AboutService1");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var Data = JsonConvert.DeserializeObject<List<AboutService1ListViewModel>>(jsonData);
                return View(Data);
            }
            return View();
        }
    }
}
