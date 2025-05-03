namespace Dotnet_server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Dotnet_server.Models;

public class DataContext : DbContext
{
    private readonly IConfiguration _config;
    public DataContext(IConfiguration config)
    {
        _config = config;
    }
    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("DefaultConnections"),
            optionsBuilder => optionsBuilder.EnableRetryOnFailure());
        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("SignalRSchema");
        modelBuilder.Entity<User>().ToTable("Users", "SignalRSchema").HasKey(t => t.userId);
    }
}