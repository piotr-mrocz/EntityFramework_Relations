namespace EntityFramework_Relations.Models.Entities;

public class Comment
{
    public int Id { get; set; }
    public string Message { get; set; } = null!;
    public string Author { get; set; } = null!;
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }

    // relations 1 to many
    public WorkItem WorkItem { get; set; } = null!;
    public int WorkItemId { get; set; }
}
