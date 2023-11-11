public class CustomersContext(string connectionString) : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder
            .UseMongoDB(connectionString, "Customers")
            .EnableSensitiveDataLogging()
            .LogTo(Console.WriteLine, LogLevel.Information);

    public DbSet<Customer> Customers { get; set; }
}