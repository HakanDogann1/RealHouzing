using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models;
using System.Text;

namespace RealHouzing.Consume.Controllers
{
    public class Property2Controller : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public Property2Controller(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44373/api/Property2");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var Data = JsonConvert.DeserializeObject<List<Property2ListViewModel>>(jsonData);
                return View(Data);
            }
            return View();
        }

        [HttpGet]
        public IActionResult AddProperty2()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddProperty2(AddProperty2ViewModel addProperty2ViewModel)
        {
            var client = _httpClientFactory.CreateClient();
            var JsonData = JsonConvert.SerializeObject(addProperty2ViewModel);
            StringContent stringContent = new StringContent(JsonData,Encoding.UTF8,"application/json");
            var responseMessage = await client.PostAsync("https://localhost:44373/api/Property2",stringContent);
            if(responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> DeleteProperty2(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:44373/api/Property2/{id}");
            if(responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateProperty2(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:44373/api/Property2/{id}");
            if(responseMessage.IsSuccessStatusCode)
            {
                var JsonData = await responseMessage.Content.ReadAsStringAsync();
                var Data = JsonConvert.DeserializeObject<UpdateProperty2ViewModel>(JsonData);
                return View(Data);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProperty2(UpdateProperty2ViewModel model)
        {
            var client = _httpClientFactory.CreateClient();
            var JsonData=JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(JsonData,Encoding.UTF8,"application/json");
            var responseMessage = await client.PutAsync("https://localhost:44373/api/Property2", stringContent);
            if(responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
