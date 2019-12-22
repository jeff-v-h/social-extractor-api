using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace SocialExtractor.DataService.data.Models
{
    public class SocialListBase
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public DateTime Created { get; set; }
        public string Name { get; set; }
    }
}
