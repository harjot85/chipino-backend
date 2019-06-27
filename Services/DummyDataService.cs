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

        public IEnumerable<Content> GetAllTextContent()
        {
            return _ctx.GetTextContent();
        }

        public Content GetTextContentById(int id)
        {
            return _ctx.GetTextContent().Where(c => c.Id == id).FirstOrDefault();
        }

        public IEnumerable<Media> GetAllMediaContent()
        {
            return _ctx.GetMediaContent();
        }

        public Media GetMediaContentById(int id)
        {
            return _ctx.GetMediaContent().Where(m=>m.Id==id).FirstOrDefault();
        }

        public IEnumerable<Footer> GetFooterContent()
        {
            return _ctx.GetFooterContent();
        }

        public IEnumerable<Carousel> GetCarouselContent()
        {
            return _ctx.GetCarouselContent();
        }

        public Task<bool> AddGitRepository(Models.GitHubRepository repository)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveGitRepository(int repositoryId)
        {
            throw new NotImplementedException();
        }
    }
}
