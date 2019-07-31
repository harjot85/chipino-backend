using backend_website.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using backend_website.Data;
using backend_website.Models;

namespace backend_website.Services
{
    public class MongoDbService : IService
    {
        private readonly IRepositoryData _ctx;

        public MongoDbService()
        {
            _ctx = new MongoDbData("chipinoDB");
        }

        public async Task<IEnumerable<Content>> GetAllTextContent()
        {
            return await _ctx.GetTextContent();
        }

        public async Task<Content> GetTextContentById(int id)
        {
            var result = await _ctx.GetTextContent();
            return result.Where(c => c.Id == id).FirstOrDefault();
        }

        public async Task<IEnumerable<Media>> GetAllMediaContent()
        {
            return await _ctx.GetMediaContent();
        }

        public async Task<Media> GetMediaContentById(int id)
        {
            var result = await _ctx.GetMediaContent();
            return result.Where(m => m.Id == id).FirstOrDefault();
        }

        public async Task<IEnumerable<Footer>> GetFooterContent()
        {
            return await _ctx.GetFooterContent();
        }

        public async Task<List<Navbar>> GetNavbarItems()
        {
            return await _ctx.GetNavbarItems();
        }

        public async Task<IEnumerable<Carousel>> GetCarouselContent()
        {
            return await _ctx.GetCarouselContent();
        }

        public async Task<bool> AddGitRepository(GitHubRepo repository)
        {
            return await _ctx.AddRepository(repository);
        }

        public async Task<bool> RemoveGitRepository(int repositoryId)
        {
            return await _ctx.RemoveRepository(repositoryId);
        }

        public async Task<IEnumerable<GitHubRepo>> GetAllRepositories()
        {
            return await _ctx.GetAllRepositories();
        }

        public async Task<IEnumerable<GitHubRepo>> GetFilteredRepositories(FilterModel fm)
        {
            return await _ctx.GetFilteredRepositories(fm);
        }
    }
}
