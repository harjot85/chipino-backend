using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend_website.Data;
using backend_website.Models;
using backend_website.Services;
using Microsoft.AspNetCore.Mvc;

namespace backend_website.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class ContentController : Controller
    {
        private readonly DummyDataService _localService;
               
        public ContentController(DummyDataService service)
        {

            _localService = service;
        }

        [HttpGet]
        public IActionResult GetAllContent()
        {
            return Ok(_localService.GetAllTextContent());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetTextContentById(int id)
        {
            return Ok(_localService.GetTextContentById(id));
        }
    }
}