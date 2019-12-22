using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace SocialExtractor.DataService.data.Models
{
    public class SocialMediaListsDetails
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public DateTime Created { get; set; }
        public List<SocialListBase> Lists { get; set; }
    }
}
