using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace mongodb.Models
{

    [BsonIgnoreExtraElements]
    public class Banki
    {
        [BsonId]
        public ObjectId _id { get; set; }

        [BsonElement("Назив на Банка")]
        public string Name { get; set; }

    }
}