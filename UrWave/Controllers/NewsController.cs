using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Web.BackOffice.Controllers;
using UrWave.Services.News_Service;

namespace UrWave.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly ILogger<NewsController> logger;
        private readonly INewsService newsService;
        public NewsController(ILogger<NewsController> logger, INewsService newsService)
        {
            this.logger = logger;
            this.newsService = newsService;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetNews()
        {
            logger.LogInformation("Getting all GetNews");
            var data = await newsService.GetAll();
            logger.LogInformation("Sucessfully retrieved all news");
            return Ok(data);
        }
    }
}
