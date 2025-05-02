namespace Dotnet_server.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
        
    }
}