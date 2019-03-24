using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Test.Models
{
    public class TestMongoConnection
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id {get; set;}

        [BsonElement("ItemOne")]
        public string ItemOne {get; set;}

        [BsonElement("ItemTwo")]
        public string ItemTwo { get; set; }

        [BsonElement("ItemThree")]
        public string ItemThree { get; set; }
    }
}