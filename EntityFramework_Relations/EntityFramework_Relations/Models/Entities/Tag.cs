namespace EntityFramework_Relations.Models.Entities;

public class Tag
{
    public int Id { get; set; }
    public string Value { get; set; } = null!;

    // relation many to many

    public List<WorkItem> WorkItems { get; set; } = new List<WorkItem>(); // that's why we don't need to create new table with relation between 
                                                                          // 2 tables WorkItem and Tag
                                                                          // but we must do it if we use .Net < .Net 5
                                                                          // but if we need to save some date strictly related to the relations between this
                                                                          // 2 tables, we have to create additional table joining tables and in this place
                                                                          // we can add additional property that we need
}
