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
            return _ctx.GetMediaContent().Where(m => m.Id == id).FirstOrDefault();
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
            return _ctx.AddRepository(repository);
        }

        public Task<bool> RemoveGitRepository(int repositoryId)
        {
            return _ctx.RemoveRepository(repositoryId);
        }
    }
}
