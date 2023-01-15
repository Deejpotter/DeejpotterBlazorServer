using DeejpotterBlazorServer.Shared.Models.Classes;
using DeejpotterBlazorServer.Shared.Repositories;

namespace DeejpotterBlazorServer.Shared.Services;

public class WorkItemService
{
    private readonly IWorkItemRepository _workItemRepository;

    public WorkItemService(IWorkItemRepository workItemRepository)
    {
        _workItemRepository = workItemRepository;
    }

    public async Task<IEnumerable<IWorkItem>> GetAllWorkItems()
    {
        return await _workItemRepository.GetAllWorkItems();
    }

    public async Task<IWorkItem> GetWorkItem(string id)
    {
        return await _workItemRepository.GetWorkItem(id);
    }

    public async Task CreateWorkItem(IWorkItem item)
    {
        await _workItemRepository.CreateWorkItem(item);
    }

    public async Task UpdateWorkItem(string id, IWorkItem item)
    {
        await _workItemRepository.UpdateWorkItem(id, item);
    }

    public async Task DeleteWorkItem(string id)
    {
        await _workItemRepository.DeleteWorkItem(id);
    }
}