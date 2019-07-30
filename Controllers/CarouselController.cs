using backend_website.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace backend_website.Controllers
{
    [Route("/api/[controller]")]
    [EnableCors("ChipinoOriginPolicy")]
    [ApiController]
    public class CarouselController : Controller
    {
        //private readonly DummyDataService _localService;
        private readonly MongoDbService _service;

        public CarouselController(MongoDbService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Ok(await _service.GetCarouselContent());
        }
    }
}