namespace SlimeHero.Data.Common.Models.Mongo
{
    using System;
    using MongoDB.Bson;

    public abstract class Document : IDocument
    {
        public ObjectId Id { get; set; }

        public DateTime CreatedAt => Id.CreationTime;
    }
}
