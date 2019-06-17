using backend_website.Models;
using backend_website.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace backend_website.Controllers
{
    [Route("/api/[controller]")]
    [EnableCors("ChipinoOriginPolicy")]
    [ApiController]
    public class UpdateGitRepoCollectionController : Controller
    {
        private readonly MongoDbService _service;

        private const string Added = "created";
        private const string Removed = "deleted";

        public UpdateGitRepoCollectionController(MongoDbService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult UpdateGitRepoCollection([FromBody] dynamic repository)
        {
            string result = string.Empty;
            var repo = new GitHubRepository
            {
                Action = repository.action,
                Id = repository.repository.id,
                Name = repository.repository.name,
                Description = repository.repository.description
            };

            if (!string.IsNullOrEmpty(repo.Action))
            {
                if (repo.Action == Added)
                { }
                if (repo.Action == Removed)
                { }
            }
            return Ok(result);
        }
    }
}