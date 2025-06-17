using Microsoft.EntityFrameworkCore;

namespace LotteryService.Data;
public class DatabaseContext : DbContext
{
   // public DbSet<User> Users { get; set; }  // Example table
    private readonly IConfiguration _configuration;

    public DatabaseContext(IConfiguration configuration)
    {
        _configuration = configuration;
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connStr = _configuration.GetConnectionString("Database_lottery")!;
        optionsBuilder.UseSqlServer(connStr);
    }
}