using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace backend_website.Controllers
{
    [Route("/api/[controller]")]
    [EnableCors("ChipinoOriginPolicy")]
    [ApiController]
    public class ValuesController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return await Task.Run(()=> Ok("This is Async/Get from Values controller"));
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return await Task.Run(() => Ok($"This is Async/Get with Id from Values controller, Id: {id}"));
        }
    }
}
