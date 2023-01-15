namespace DeejpotterBlazorServer.Shared.Repositories;

public interface IMongoDbSettings
{
    string ConnectionString { get; set; }
    string DatabaseName { get; set; }
}
