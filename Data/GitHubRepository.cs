using backend_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_website.Data
{
    public class GitHubRepository
    {
        public async Task<IEnumerable<GitHubRepo>> GetAllRepos()
        {
            var res = new List<GitHubRepo> {
                new GitHubRepo(){Id=101, Name="First Repo", Description="Demo Repo 1", Language="C#"},
                new GitHubRepo(){Id=103, Name="Third Repo", Description="Demo Repo 3", Language="JavaScript"},
                new GitHubRepo(){Id=104, Name="Fourth Repo", Description="Demo Repo 4", Language="Java"},
                new GitHubRepo(){Id=105, Name="Fifth Repo", Description="Demo Repo 5", Language="Django"},
                new GitHubRepo(){Id=102, Name="Second Repo", Description="Demo Repo 2", Language="CSS"},
            };
            return await Task.Run(()=>res);
        }
    }
}
