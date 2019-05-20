using backend_website.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace backend_website.Controllers
{
    [Route("/api/[controller]")]
    [EnableCors("ChipinoOriginPolicy")]
    [ApiController]
    public class MediaController : Controller
    {
        private readonly MongoDbService _service;

        public MediaController(MongoDbService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAllMedia()
        {
            return Ok(_service.GetAllMediaContent());
        }

        [HttpGet("id")]
        public IActionResult GetImageById(int id)
        {
            return Ok(_service.GetMediaContentById(id));
        }
    }
}