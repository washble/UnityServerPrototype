using Microsoft.EntityFrameworkCore;

namespace Server;

public class ServerDbContext : DbContext
{
    public ServerDbContext(DbContextOptions<ServerDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().ToTable("users");
        modelBuilder.Entity<User>().HasKey(user => new { user.device });
    }

    public DbSet<User> Users { get; set; }
}