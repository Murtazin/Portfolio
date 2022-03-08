using Microsoft.EntityFrameworkCore;
using Portfolio.Models;

namespace Portfolio;

public class ApplicationContext : DbContext
{
    public DbSet<User> Users { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=renatmurtazin;Password=Admin123");
    }
}