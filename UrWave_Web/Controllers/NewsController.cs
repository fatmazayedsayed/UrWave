using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UrWave.Model.Dtos;
using UrWave_Web.WebHelper;
using static UrWave.Model.Dtos.Response;

namespace UrWave_Web.Controllers
{
    public class NewsController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<NewsDto> newsList = new List<NewsDto>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(WebAPICall.GetAPICall(APIEnum.news)))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    newsList = (JsonConvert.DeserializeObject<Root<NewsDto>>(apiResponse)).result;
                }
            }
            return View(newsList);
        }
    }
}
