using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace NBAProject.Models.Documents
{
    public class Document : IDocument
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public ObjectId Id { get; set; }

        public DateTime CreatedAt { get; }
    }

    public interface IDocument
    {
        public ObjectId Id { get; set; }

        public DateTime CreatedAt => Id.CreationTime;
    }
}