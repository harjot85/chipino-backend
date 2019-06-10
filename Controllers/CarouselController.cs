using backend_website.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Index()
        {
            return Ok(_service.GetCarouselContent());
        }
    }
}