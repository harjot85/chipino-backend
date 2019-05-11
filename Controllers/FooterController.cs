using backend_website.Services;
using Microsoft.AspNetCore.Mvc;

namespace backend_website.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class FooterController : Controller
    {
        private readonly DummyDataService _localService;

        public FooterController(DummyDataService service)
        {
            _localService = service;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(_localService.GetFooterContent());
        }
    }
}