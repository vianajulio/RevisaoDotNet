using Microsoft.EntityFrameworkCore;
using PraticaCodigo.Models.ItemsOrders;
using PraticaCodigo.Models.Orders;

namespace PraticaCodigo.Infraestructure;

public class DatabaseContext : DbContext
{
    public DbSet<Order> Orders { get; set; }
    public DbSet<ItemOrder> ItemOrders { get; set; }

    public DatabaseContext(DbContextOptions<DatabaseContext> options) 
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DatabaseContext).Assembly);
    }
}
