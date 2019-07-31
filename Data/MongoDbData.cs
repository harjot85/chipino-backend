using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend_website.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace backend_website.Data
{
    public class MongoDbData : IRepositoryData
    {
        private readonly string _connString = string.IsNullOrEmpty(Environment.GetEnvironmentVariable("MONGODB_CONNSTRING")) ? Startup.ConnectionString : Environment.GetEnvironmentVariable("MONGODB_CONNSTRING");
        private readonly IMongoDatabase _db;

        public MongoDbData(string dbName)
        {
            var client = new MongoClient(_connString);
            _db = client.GetDatabase(dbName);
        }

        public async Task<IEnumerable<Content>> GetTextContent()
        {
            var coll = _db.GetCollection<Content>("ChipinoText");
            return await Task.Run(() => coll.Find(new BsonDocument()).ToEnumerable());
        }

        public async Task<IEnumerable<Media>> GetMediaContent()
        {
            var coll = _db.GetCollection<Media>("ChipinoMedia");
            return await Task.Run(()=>coll.Find(new BsonDocument()).ToEnumerable());
        }

        public async Task<IEnumerable<Footer>> GetFooterContent()
        {
            var coll = _db.GetCollection<Footer>("ChipinoFooter");
            return await Task.Run(()=>coll.Find(new BsonDocument()).ToEnumerable());
        }

        public async Task<IEnumerable<Carousel>> GetCarouselContent()
        {
            var coll = _db.GetCollection<Carousel>("ChipinoCarousel");
            return await Task.Run(()=>coll.Find(new BsonDocument()).ToEnumerable());
        }

        public async Task<List<Navbar>> GetNavbarItems()
        {
            var coll = _db.GetCollection<Navbar>("ChipinoNavbar");
            return await coll.Find(new BsonDocument()).ToListAsync();
        }

        public async Task<bool> AddRepository(GitHubRepo repository)
        {
            bool result = false;
            var newRepo = _db.GetCollection<GitHubRepo>("ChipinoGitRepos");
            try
            {
                await newRepo.InsertOneAsync(repository);
                result = true;
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }

            return result;
        }

        public async Task<bool> RemoveRepository(int repositoryId)
        {
            bool isRemoved = false;
            var repo = _db.GetCollection<GitHubRepo>("ChipinoGitRepos");
            try
            {
                var response = await repo.DeleteOneAsync(Builders<GitHubRepo>.Filter.Eq("_id", repositoryId));
                isRemoved = response.IsAcknowledged;
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }

            return isRemoved;
        }

        public async Task<IEnumerable<GitHubRepo>> GetAllRepositories()
        {
            IMongoCollection<GitHubRepo> res = _db.GetCollection<GitHubRepo>("ChipinoGitRepos");
            return await res.Find(_=> true).ToListAsync();
        }

        public async Task<IEnumerable<GitHubRepo>> GetFilteredRepositories(FilterModel fm)
        {
            IMongoCollection<GitHubRepo> res = _db.GetCollection<GitHubRepo>("ChipinoGitRepos");
            return await res.Find(_ => _.Language.Equals(fm.Language)).ToListAsync();
        }
    }
}
