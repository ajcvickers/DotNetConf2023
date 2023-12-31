﻿using System.Linq;

await using (var context = new CustomersContext())
{
    await context.Database.EnsureDeletedAsync();
    await context.Database.EnsureCreatedAsync();

    context.AddRange(SampleData.CreateSampleCustomers());
    await context.SaveChangesAsync();
}

await using (var context = new CustomersContext())
{
    var specialDays = new List<DateTime>
    {
        new(2008, 5, 20), new(2014, 11, 21), new(2019, 1, 4),
        new(2022, 6, 11), new(2013, 2, 2), new(2023, 5, 4)
    };
    var customersWhoJoinedOnSpecialDays = await context.Set<Customer>()
        .Where(c => specialDays.Contains(c.MemberSince))
        .ToListAsync();
}
