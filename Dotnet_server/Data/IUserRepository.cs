using System;
using Dotnet_server.Models;

namespace Dotnet_server.Data;

public interface IUserRepository
{
    public bool SaveChanges();
    public void AddEntity<T>(T entityToAdd);
    public void RemoveEntity<T>(T entityToRemove);
    public IEnumerable<User> GetUsers();
    public User GetSingleUser (int UserId);
}
