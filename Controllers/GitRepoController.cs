using backend_website.Models;
using backend_website.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace backend_website.Controllers
{
    [Route("/api/[controller]")]
    [EnableCors("ChipinoOriginPolicy")]
    [ApiController]
    public class GitRepoController : Controller
    {
        private readonly MongoDbService _service;

        private const string Added = "created";
        private const string Removed = "deleted";

        public GitRepoController(MongoDbService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddGitRepo([FromBody] dynamic repository)
        {
            var newRepo = new GitHubRepository
            {
                Id = repository.repository.id,
                Name = repository.repository.name,
                Description = repository.repository.description
            };
            bool result = await _service.AddGitRepository(newRepo);
            return Ok(result);
        }

        [HttpPost]
        [Route("remove")]
        public async Task<IActionResult> RemoveGitRepo([FromBody] dynamic repository)
        {
            var removeRepo = new GitHubRepository
            {
                Id = repository.repository.id
            };
            bool result = await _service.RemoveGitRepository(removeRepo.Id);
            return Ok(result);
        }
    }
}