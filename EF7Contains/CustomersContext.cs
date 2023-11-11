public class CustomersContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder
            .UseSqlServer(UserSecrets.Read("ConfDemoEF7"))
            //.UseCosmos("https://localhost:8081", UserSecrets.Read("CosmosKey"), "Customers")
            .EnableSensitiveDataLogging()
            .LogTo(Console.WriteLine, LogLevel.Information);

    public DbSet<Customer> Customers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(b =>
        {
            b.OwnsOne(e => e.Details, b =>
            {
                b.OwnsMany(e => e.Addresses);
                b.OwnsMany(e => e.PhoneNumbers);
                b.ToJson();
            });
        });
    }
}