using System;
using Dotnet_server.Models;

namespace Dotnet_server.Data;

public class UserRepository : IUserRepository
{
    DataContext _entityFramework;
    public UserRepository(IConfiguration config)
    {
        _entityFramework = new DataContext(config);
    }

    public bool SaveChanges()
    {
        return _entityFramework.SaveChanges() > 0;
    }
    public void AddEntity<T>(T entityToAdd)
    {
        if (entityToAdd != null) _entityFramework.Add(entityToAdd);
    }

    public User GetSingleUser(int UserId)
    {
        User? user = _entityFramework.Users.Where(u => u.userId == UserId).FirstOrDefault<User>();
        if (user != null)
        {
            return user;
        }
        throw new Exception("Failed to get user");
    }

    public IEnumerable<User> GetUsers()
    {
        IEnumerable<User> users = _entityFramework.Users.ToList<User>();
        return users;
    }

    public void RemoveEntity<T>(T entityToRemove)
    {
        if (entityToRemove != null) _entityFramework.Remove(entityToRemove);
    }

}
