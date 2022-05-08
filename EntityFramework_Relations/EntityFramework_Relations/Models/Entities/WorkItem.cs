namespace EntityFramework_Relations.Models.Entities;

public class WorkItem
{
    public int Id { get; set; }
    public string State { get; set; } = null!;
    public string Area { get; set; }
    public string InternationPath { get; set; } = null!;
    public int Priority { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal Efford { get; set; }
    public string Activity { get; set; } = null!;
    public decimal RemaningWork { get; set; }
    public string Type { get; set; } = null!;

    // relations 1 to many
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
}
