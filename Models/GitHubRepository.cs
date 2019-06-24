using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace backend_website.Models
{
    public class GitHubRepository
    {
        [BsonElement("RepoId")]
        public int Id { get; set; }
        [BsonElement("RepoName")]
        public string Name { get; set; }
        [BsonElement("RepoDescription")]
        public string Description { get; set; }
    }
}
 