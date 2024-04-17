using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Khinov_LR9.Models;
using System.Text.Json.Serialization;
using System;
using System.Net.Http.Json;

namespace Khinov_LR9.Components
{
    public class WeatherMapViewComponent : ViewComponent
    {
        string key = "8015ad81ff4a74e54e51e2fff04ebd71";
        public async Task<IViewComponentResult> InvokeAsync(string city)
        {
            var url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={key}&units=metric";
            Console.WriteLine(url);
            using (var http = new HttpClient())
            {
                using (var response = await http.GetAsync(url))
                {
                    using (var content = response.Content)
                    {
                        var result = await content.ReadAsStringAsync();
                        ResponseWeather resp1 = JsonConvert.DeserializeObject<ResponseWeather>(result);
                        return View(resp1);
                    }
                }
            }
        }
    }
}
