using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_website.Models
{
    public class GitHubRepo
    {
        public int RepoId { get; set; }
        public string RepoTitle { get; set; }
        public string RepoDescription { get; set; }
    }
}
