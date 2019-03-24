using MongoDB.Driver;
using Test.Models;
using Microsoft.Extensions.Configuration;

namespace Test.Services
{
    public class TestService
    {
        public TestService(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("MongoDb"));
            var database = client.GetDatabase(config.GetConnectionString("Database"));
            _test = database.GetCollection<TestMongoConnection>("ChipinoTextContent");
        }
        private readonly IMongoCollection<TestMongoConnection> _test;
        public TestMongoConnection Get()
        {
            return _test.Find<TestMongoConnection>(person => true).FirstOrDefault();
        }
    }
}