using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Test.Models
{
    public class TestMongoConnection
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id {get; set;}

        [BsonElement("SocialMedia")]
        public string SocialMedia {get; set;}

        [BsonElement("IconClass")]
        public string Icon { get; set; }

        [BsonElement("Link")]
        public string Link { get; set; }
    }
}