using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_website.Models
{
    public class GitHubRepo
    {
        [BsonElement("RepoId")]
        public int Id { get; set; }
        [BsonElement("RepoName")]
        public string Name { get; set; }
        [BsonElement("RepoDescription")]
        public string Description { get; set; }
        [BsonElement("RepoLanguage")]
        public string Language { get; set; }
    }
}
