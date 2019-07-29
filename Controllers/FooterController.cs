using backend_website.Models;
using backend_website.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace backend_website.Controllers
{
    [Route("/api/[controller]")]
    [EnableCors("ChipinoOriginPolicy")]
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
        public async Task<IActionResult> Index()
        {            
            return Ok(await _service.GetFooterContent());
        }
    }
}