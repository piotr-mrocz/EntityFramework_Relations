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

    // relations 1 to many - we have to create foreign key (e.g. AuthorId), where is 1
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public User Author { get; set; } = null!;
    public Guid AuthorId { get; set; }

    // relation many to many
    public List<Tag> Tags { get; set; } = new List<Tag>(); // that's why we don't need to create new table with relation between 
                                                           // 2 tables WorkItem and Tag
                                                           // but we must do it if we use .Net < .Net 5
                                                           // but if we need to save some date strictly related to the relations between this
                                                           // 2 tables, we have to create additional table joining tables and in this place
                                                           // we can add additional property that we need
}
