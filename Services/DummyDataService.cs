using backend_website.Data;
using backend_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_website.Services
{
    public class DummyService : IService
    {
        private readonly IRepositoryData _ctx;
        
        public DummyService()
        {
            _ctx = new DummyData();
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
            return result.Where(m=>m.Id==id).FirstOrDefault();
        }

        public async Task<IEnumerable<Footer>> GetFooterContent()
        {
            return await _ctx.GetFooterContent();
        }

        public async Task<IEnumerable<Carousel>> GetCarouselContent()
        {
            return await _ctx.GetCarouselContent();
        }

        public Task<List<Navbar>> GetNavbarItems()
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddGitRepository(GitHubRepo repository)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveGitRepository(int repositoryId)
        {
            throw new NotImplementedException();
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
