using Microsoft.EntityFrameworkCore;

namespace BackendWorkshop;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    
    public DbSet<Article> Articles { get; set; }
    public DbSet<AbstractUser> Users { get; set; }
}

public class USDbContext: DbContext
{
    public USDbContext(DbContextOptions<USDbContext> options) : base(options)
    {
    }
    
    public DbSet<Article> Articles { get; set; }
    public DbSet<User> Users { get; set; }
}

public class RUDbContext: DbContext
{
    public RUDbContext(DbContextOptions<RUDbContext> options) : base(options)
    {
    }
    
    public DbSet<Article> Articles { get; set; }
    public DbSet<User> Users { get; set; }
}