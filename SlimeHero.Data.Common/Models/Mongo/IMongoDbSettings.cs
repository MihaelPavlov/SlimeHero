namespace SlimeHero.Data.Common.Models.Mongo
{
    public interface IMongoDbSettings
    {
        string DatabaseName { get; set; }
        string ConnectionString { get; set; }
    }
}
