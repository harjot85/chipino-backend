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
    }
}
