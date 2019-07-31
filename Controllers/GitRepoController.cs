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

        public GitRepoController(MongoDbService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("getAllRepos")]
        public async Task<IActionResult> GetAllRepositories()
        {
            return Ok(await _service.GetAllRepositories());
        }

        [HttpGet]
        [Route("getFilteredRepos")]
        public async Task<IActionResult> GetFilteredRepositories([FromQuery] FilterModel fm)
        {
            return Ok(await _service.GetFilteredRepositories(fm));
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddGitRepo([FromBody] dynamic repository)
        {
            var newRepo = new GitHubRepo
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
            var removeRepo = new GitHubRepo
            {
                Id = repository.repository.id
            };
            bool result = await _service.RemoveGitRepository(removeRepo.Id);
            return Ok(result);
        }
    }
}