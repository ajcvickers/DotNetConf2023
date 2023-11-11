public class SampleData
{
    public static IList<Customer> CreateSampleCustomers()
        => new Customer[]
        {
            new()
            {
                Name = "Willow",
                MemberSince = new DateOnly(2008, 5, 20),
                Details = new()
                {
                    Addresses =
                    {
                        new()
                        {
                            Street = "Baking Gate",
                            City = "Walpole St Peter",
                            Postcode = "PE157ZN",
                            Country = "UK",
                            IsPrimary = true
                        }
                    },
                    PhoneNumbers =
                    {
                        new()
                        {
                            CountryCode = 1,
                            Number = "(555) 234-2333",
                        },
                        new()
                        {
                            CountryCode = 44,
                            Number = "(1234) 1234-333",
                            IsPrimary = true
                        }
                    }
                }
            },
            new()
            {
                Name = "Toast",
                Visits = new()
                {
                    new DateTime(2014, 5, 1, 12, 0, 0),
                    new DateTime(2014, 6, 1, 12, 30, 0),
                    new DateTime(2018, 1, 1, 12, 15, 0)
                },
                MemberSince = new DateOnly(2018, 1, 21),
                Details = new()
                {
                    Addresses =
                    {
                        new()
                        {
                            Street = "The Old Pub",
                            City = "Walpole St Andrews",
                            Postcode = "PE157AN",
                            Country = "UK"
                        },
                        new()
                        {
                            Street = "Peacock Manor",
                            City = "Walpole St Peter",
                            Postcode = "PE159ZN",
                            Country = "UK",
                            IsPrimary = true
                        },
                    },
                    PhoneNumbers =
                    {
                        new()
                        {
                            CountryCode = 44,
                            Number = "(1234) 1234-989",
                            IsPrimary = true
                        },
                        new()
                        {
                            CountryCode = 1,
                            Number = "(123) 444-3543"
                        }
                    }
                }
            },
            new()
            {
                Name = "Baxter",
                Visits = new()
                {
                    new DateTime(2014, 5, 1, 12, 0, 0),
                    new DateTime(2014, 6, 1, 12, 30, 0),
                    new DateTime(2018, 1, 1, 12, 15, 0)
                },
                MemberSince = new DateOnly(2005, 12, 24),
                Details = new()
                {
                    Notes = new() { "Consultant for PCC" },
                    Addresses =
                    {
                        new()
                        {
                            Street = "Education House",
                            City = "Redmond",
                            Postcode = "98052",
                            Country = "US",
                            IsPrimary = true
                        },
                        new()
                        {
                            Street = "Mountain House",
                            City = "Cougar Mountain",
                            Postcode = "98051",
                            Country = "US"
                        },
                    },
                    PhoneNumbers =
                    {
                        new()
                        {
                            CountryCode = 1,
                            Number = "(123) 555-5333",
                            IsPrimary = true
                        },
                        new()
                        {
                            CountryCode = 44,
                            Number = "(1234) 1234-133"
                        }
                    }
                }
            }
        };
}