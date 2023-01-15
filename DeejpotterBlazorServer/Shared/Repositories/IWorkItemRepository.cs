using DeejpotterBlazorServer.Shared.Models.Classes;

namespace DeejpotterBlazorServer.Shared.Repositories;

public interface IWorkItemRepository
{
    Task<IEnumerable<IWorkItem>> GetAllWorkItems();
    Task<IWorkItem> GetWorkItem(string id);
    Task CreateWorkItem(IWorkItem workItem);
    Task UpdateWorkItem(string id, IWorkItem workItem);
    Task DeleteWorkItem(string id);
}