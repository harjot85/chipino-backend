using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend_website.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace backend_website.Controllers
{
    [Route("/api/[controller]")]
    [EnableCors("ChipinoOriginPolicy")]
    [ApiController]
    public class ConfigurationController : Controller
    {
        private readonly MongoDbService _service;

        public ConfigurationController(MongoDbService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetConfiguration()
        {
            return Ok(await _service.GetConfiguration());
        }
    }
}