using Microsoft.EntityFrameworkCore;

namespace az204_dotnet_core_api_sample.Models;

class PizzaDb : DbContext
{
    public PizzaDb(DbContextOptions<PizzaDb> options) : base(options) { }
    public DbSet<Pizza> Pizzas { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pizza>()
            .ToContainer("Pizzas")  // Optional: Specify a container name
            .HasPartitionKey(p => p.Id);  // Use the Id as the partition key
    }
}