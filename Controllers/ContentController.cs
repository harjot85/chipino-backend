using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend_website.Data;
using backend_website.Models;
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
        private readonly DummyService _localService;
        private readonly MongoDbService _service;

        public ContentController(MongoDbService service)
        {
            //_localService = service;
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAllContent()
        {
            return Ok(_service.GetAllTextContent());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetTextContentById(int id)
        {
            return Ok(_service.GetTextContentById(id));
        }
    }
}