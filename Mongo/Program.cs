await using var mongoContainer = new MongoDbBuilder().WithImage("mongo:6.0").Build();
await mongoContainer.StartAsync();

await using (var context = new CustomersContext(mongoContainer.GetConnectionString()))
{
    context.AddRange(SampleData.CreateSampleCustomers());
    await context.SaveChangesAsync();
}

var client = new MongoClient(mongoContainer.GetConnectionString());
var collection = client.GetDatabase("Customers").GetCollection<BsonDocument>("Customers");
var documents = await collection.Find(Builders<BsonDocument>.Filter.Empty).ToListAsync();
foreach (var document in documents)
{
    Console.WriteLine(document);
}
