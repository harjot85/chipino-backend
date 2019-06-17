using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace backend_website.Models
{
    public class GitHubRepository
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Action { get; set; }
    }
}
