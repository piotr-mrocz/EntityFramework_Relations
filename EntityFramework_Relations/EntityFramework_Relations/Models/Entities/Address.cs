namespace EntityFramework_Relations.Models.Entities;

public class Address
{
    public Guid Id { get; set; }
    public string Country { get; set; } = null!;
    public string City { get; set; } = null!;
    public string Street { get; set; } = null!;
    public string PostalCode { get; set; } = null!;

    // relations 1 to 1
    public User User { get; set; } = null!;

    //because address is dependent on user
    public Guid UserId { get; set; }
}
