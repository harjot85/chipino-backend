using backend_website.Services;
using Microsoft.AspNetCore.Mvc;

namespace backend_website.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class FooterController : Controller
    {
        //private readonly DummyDataService _localService;
        private readonly MongoDbService _service;

        public FooterController(MongoDbService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(_service.GetFooterContent());
        }
    }
}