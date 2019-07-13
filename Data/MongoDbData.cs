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

        public IEnumerable<Content> GetTextContent()
        {
            var coll = _db.GetCollection<Content>("ChipinoText");
            return coll.Find(new BsonDocument()).ToList();
        }

        public IEnumerable<Media> GetMediaContent()
        {
            var coll = _db.GetCollection<Media>("ChipinoMedia");
            return coll.Find(new BsonDocument()).ToList();
        }

        public IEnumerable<Footer> GetFooterContent()
        {
            var coll = _db.GetCollection<Footer>("ChipinoFooter");
            return coll.Find(new BsonDocument()).ToList();
        }

        public IEnumerable<Carousel> GetCarouselContent()
        {
            var coll = _db.GetCollection<Carousel>("ChipinoCarousel");
            return coll.Find(new BsonDocument()).ToList();
        }

        public async Task<bool> AddRepository(Models.GitHubRepository repository)
        {
            bool result = false;
            var newRepo = _db.GetCollection<Models.GitHubRepository>("ChipinoGitRepos");
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
            var repo = _db.GetCollection<Models.GitHubRepository>("ChipinoGitRepos");
            try
            {
                var response = await repo.DeleteOneAsync(Builders<Models.GitHubRepository>.Filter.Eq("_id", repositoryId));
                isRemoved = response.IsAcknowledged;
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }

            return isRemoved;
        }
    }
}
