public class Customer
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public List<DateTime>? Visits { get; set; }
    public required CustomerDetails Details { get; set; }
    public required DateTime MemberSince { get; set; }
}

public class CustomerDetails
{
    public List<string>? Notes { get; set; }
    public List<Phone> PhoneNumbers { get; } = new();
    public List<Address> Addresses { get; } = new();
}

public class Address
{
    public required string Street { get; set; }
    public required string City { get; set; }
    public required string Postcode { get; set; }
    public required string Country { get; set; }
    public bool IsPrimary { get; set; }
}

public class Phone
{
    public required int CountryCode { get; set; }
    public required string Number { get; set; }
    public bool IsPrimary { get; set; }
}
