using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models;
using System.Text;

namespace RealHouzing.Consume.Controllers
{
    public class ContactMapController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ContactMapController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44373/api/ContactMap");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var Data = JsonConvert.DeserializeObject<List<ContactMapListViewModel>>(jsonData);
                return View(Data);
            }
            return View();
        }

        [HttpGet]
        public IActionResult AddContactMap()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddContactMap(AddContactMapViewModel model)
        {
            var client = _httpClientFactory.CreateClient();
            model.Status = true;
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData,Encoding.UTF8,"application/json");
            var responseMessage = await client.PostAsync("https://localhost:44373/api/ContactMap", stringContent);
            if(responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> PasifContactMap(int id)
        {
            UpdateContactMapViewModel model = new UpdateContactMapViewModel();
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync($"https://localhost:44373/api/ContactMap/{id}", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {

                return RedirectToAction("Index");
            }
            return View();

        }

        public async Task<IActionResult> AktifContactMap(int id)
        {
            UpdateContactMapViewModel model = new UpdateContactMapViewModel();
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync($"https://localhost:44373/api/ContactMap/{id}", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {

                return RedirectToAction("Index");
            }
            return View();

        }

    }
}
