using DeejpotterBlazorServer.Shared.Models.Classes;
using DeejpotterBlazorServer.Shared.Services;

namespace DeejpotterBlazorServer.Shared.Templates;

public partial class IndexTemplate
{
    private WorkItemService _workItemService;
    private IEnumerable<IWorkItem> WorkItems { get; set; }
    public string IndexName { get; set; }
    public string IndexDescription { get; set; }

    public IndexTemplate(WorkItemService workItemService)
    {
        _workItemService = workItemService;
    }

    protected override async Task OnInitializedAsync()
    {
        WorkItems = await _workItemService.GetAllWorkItems();
    }
}