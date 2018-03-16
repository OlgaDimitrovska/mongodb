using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace mongodb.Models
{
    [BsonIgnoreExtraElements]
    public class Info
    {
        [BsonId]
        public ObjectId _id { get; set; }
        [BsonElement("Датум")]
        public string Date { get; set; }
        [BsonElement("Валута")]
        public string Valuta { get; set; }
        [BsonElement("Куповен")]
        public double Kupoven { get; set; }
        [BsonElement("Среден")]
        public double Sreden { get; set; }
        [BsonElement("Продажен")]
        public double Prodazen { get; set; }
        [BsonElement("Назив на Банка")]
        public Banki Banka { get; set; }
          

    }
}