namespace EntityFramework_Relations.Models.Entities;

public class User
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;

    // relations 1 to 1
    public Address Address { get; set; } = null!;
}
