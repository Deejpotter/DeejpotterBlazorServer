using DeejpotterBlazorServer.Shared.Models.Classes;
using DeejpotterBlazorServer.Shared.Repositories;
using MongoDB.Driver;

public class WorkItemRepository : IWorkItemRepository
{
    private readonly IMongoCollection<IWorkItem> _workItems;

    public WorkItemRepository(IMongoDbSettings settings)
    {
        var client = new MongoClient(settings.ConnectionString);
        var database = client.GetDatabase(settings.DatabaseName);

        _workItems = database.GetCollection<IWorkItem>(nameof(IWorkItem));
    }

    public async Task<IEnumerable<IWorkItem>> GetAllWorkItems()
    {
        return await _workItems.Find(workItem => true).ToListAsync();
    }

    public async Task<IWorkItem> GetWorkItem(string id)
    {
        return await _workItems.Find(workItem => workItem.Id == id).FirstOrDefaultAsync();
    }

    public async Task CreateWorkItem(IWorkItem workItem)
    {
        await _workItems.InsertOneAsync(workItem);
    }

    public async Task UpdateWorkItem(string id, IWorkItem workItem)
    {
        await _workItems.ReplaceOneAsync(i => i.Id == id, workItem);
    }

    public async Task DeleteWorkItem(string id)
    {
        await _workItems.DeleteOneAsync(workItem => workItem.Id == id);
    }
}