using backend_website.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
        public async Task<IActionResult> GetAllMedia()
        {
            return Ok(await _service.GetAllMediaContent());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetImageById(int id)
        {
            return Ok(await _service.GetMediaContentById(id));
        }
    }
}