﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models;

namespace RealHouzing.Consume.Components.AboutHomePage
{
    public class _AboutHeaderPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AboutHeaderPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync(AboutHeaderListViewModel model)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44373/api/AboutHeader");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var Data = JsonConvert.DeserializeObject<List<AboutHeaderListViewModel>>(jsonData);
                return View(Data);
            }
            return View();
        }
    }
}
