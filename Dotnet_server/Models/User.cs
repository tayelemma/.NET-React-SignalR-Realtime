namespace Dotnet_server.Models;

public partial class User
{
    public int userId { get; set; }
    public string FirstName { get; set; } 
    public string LastName { get; set; } = "";
    public string Email { get; set; } = string.Empty;
    public bool Active { get; set; }

    public User()
    {
        if (FirstName is null)
        {
            FirstName = "";
        }
    }
    
}