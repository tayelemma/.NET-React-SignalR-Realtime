namespace Dotnet_server.Models;

public partial class User
{
    public int UserId { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = "";
    public string Email { get; set; }
    public bool Active { get; set; }
    
}