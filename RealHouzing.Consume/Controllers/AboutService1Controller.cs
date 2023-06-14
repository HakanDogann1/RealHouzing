using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models;
using System.Text;

namespace RealHouzing.Consume.Controllers
{
    public class AboutService1Controller : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AboutService1Controller(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44373/api/AboutService1");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var Data = JsonConvert.DeserializeObject<List<AboutService1ListViewModel>>(jsonData);
                return View(Data);
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateAboutService1(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage =await client.GetAsync($"https://localhost:44373/api/AboutService1/{id}");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var Data = JsonConvert.DeserializeObject<UpdateAboutService1ViewModel>(jsonData);
                return View(Data);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAboutService1(UpdateAboutService1ViewModel model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData,Encoding.UTF8,"application/json");
            var responseMessage = await client.PutAsync("https://localhost:44373/api/AboutService1", stringContent);
            if(responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
