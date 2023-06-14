using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models;

namespace RealHouzing.Consume.Components.AboutHomePage
{
    public class _AboutQuestionHeaderPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AboutQuestionHeaderPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync(AboutQuestionHeaderListViewModel model)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44373/api/AboutQuestionHeader");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var Data = JsonConvert.DeserializeObject<List<AboutQuestionHeaderListViewModel>>(jsonData);
                return View(Data);
            }
            return View();
        }
    }
}
