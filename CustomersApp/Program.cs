await using (var context = new CustomersContext())
{
    var adultCustomers = await context.Set<Customer>()
        .Where(c => c.Details.Region == "Europe")
        .ToListAsync();
}

await using (var context = new CustomersContext())
{
    var customersWithUkAddresses = await context.Set<Customer>()
        .Where(c => c.Details.Addresses.Any(a => a.Country == "UK"))
        .ToListAsync();
}

await using (var context = new CustomersContext())
{
    var customersWithNotes = await context.Set<Customer>()
        .Where(c => c.Visits.Count > 1)
        .ToListAsync();
}

await using (var context = new CustomersContext())
{
    var from = 2010;
    var to = 2019;
    var customersInRange = await context.Set<Customer>()
        .Where(c => c.Visits.Any(v => v.Year >= from && v.Year <= to))
        .ToListAsync();
}

await using (var context = new CustomersContext())
{
    var specialDays = new List<DateOnly>
    {
        new(2008, 5, 20), new(2014, 11, 21), new(2019, 1, 4),
        new(2022, 6, 11), new(2013, 2, 2), new(2023, 5, 4)
    };
    var customersWhoJoinedOnSpecialDays = await context.Set<Customer>()
        .Where(c => specialDays.Contains(c.MemberSince))
        .ToListAsync();
}
