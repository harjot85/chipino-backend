using backend_website.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
        public async Task<IActionResult> GetAllContent()
        {
            return Ok(await _service.GetAllTextContent());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTextContentById(int id)
        {
            return Ok(await _service.GetTextContentById(id));
        }
    }
}