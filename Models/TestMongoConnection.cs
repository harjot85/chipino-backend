using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Test.Models
{
    public class TestMongoConnection
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id {get; set;}

        [BsonElement("Name")]
        public string Name {get; set;}

        [BsonElement("Age")]
        public string Age { get; set; }
    }
}