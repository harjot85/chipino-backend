using backend_website.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace backend_website.Controllers
{
    [Route("/api/[controller]")]
    [EnableCors("ChipinoOriginPolicy")]
    [ApiController]
    public class ContentController : Controller
    {
        private readonly MongoDbService _service;

        public ContentController(MongoDbService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAllContent()
        {
            return Ok(_service.GetAllTextContent());
        }

        [HttpGet("{id}")]
        public IActionResult GetTextContentById(int id)
        {
            return Ok(_service.GetTextContentById(id));
        }
    }
}