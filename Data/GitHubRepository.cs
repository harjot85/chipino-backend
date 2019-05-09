using backend_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_website.Data
{
    public class GitHubRepository
    {
        public List<GitHubRepo> GitHubRepos { get; private set; }

        private IEnumerable<GitHubRepo> GetAllRepos()
        {
            var res = new List<GitHubRepo> {
                new GitHubRepo(){RepoId=123, RepoTitle="First Repo", RepoDescription="This is my first repo"},
                new GitHubRepo(){RepoId=123, RepoTitle="First Repo", RepoDescription="This is my first repo"},
                new GitHubRepo(){RepoId=123, RepoTitle="First Repo", RepoDescription="This is my first repo"},
                new GitHubRepo(){RepoId=123, RepoTitle="First Repo", RepoDescription="This is my first repo"},
                new GitHubRepo(){RepoId=123, RepoTitle="First Repo", RepoDescription="This is my first repo"}
            };
            GitHubRepos = res;
            return res;
        }
    }
}
