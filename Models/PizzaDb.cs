using Microsoft.EntityFrameworkCore;

namespace az204_dotnet_core_api_sample.Models;

class PizzaDb : DbContext
{
    public PizzaDb(DbContextOptions options) : base(options) { }
    public DbSet<Pizza> Pizzas { get; set; } = null!;
}