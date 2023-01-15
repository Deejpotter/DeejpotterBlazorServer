namespace DeejpotterBlazorServer.Shared.Models.Classes;

public interface IWorkItem
{
    string Id { get; set; }
    string Name { get; set; }
    string Description { get; set; }
    string Link { get; set; }
}