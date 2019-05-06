using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend_website.Data;
using backend_website.Models;
using backend_website.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend_website.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class MediaController : Controller
    {
        private readonly DummyDataService _localService;
        public MediaController(DummyDataService service)
        {
            _localService = service;
        }

        [HttpGet]
        public IActionResult GetAllMedia()
        {
            return Ok(_localService.GetAllMediaContent());
        }

        [HttpGet]
        [Route("{Id}")]
        public IActionResult GetImageById(int id)
        {
            return Ok(_localService.GetMediaContentById(id));
        }
    }
}