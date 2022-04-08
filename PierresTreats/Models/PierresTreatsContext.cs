using Microsoft.EntityFrameworkCore;

namespace PierresTreats.Models
{
  public class PierresTreatsContext : DbContext
  {
    public DbSet<Engineer> Flavors { get; set; }
    public DbSet<Machine> Treats { get; set; }
    public DbSet<FlavorTreat> FlavorTreat { get; set; }

    public PierresTreatsContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}