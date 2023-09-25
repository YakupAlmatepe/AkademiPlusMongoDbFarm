using MongoDB.Bson.Serialization.Attributes;

namespace AkademiPlusMongoDbFarmWebAppMVC.Models
{
    public class About
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string AboutId { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

    }
}
