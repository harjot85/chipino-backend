using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using backend_website.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace backend_website.Controllers
{
    [Route("/api/[controller]")]
    [EnableCors("ChipinoOriginPolicy")]
    [ApiController]
    public class NavbarController : ControllerBase
    {
        private readonly MongoDbService _service;
        public NavbarController(MongoDbService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetNavbarItems()
        {
            return Ok(await _service.GetNavbarItems());
        }
    }
}