using Core.Models;
using Core.Repositories.Interfaces;
using EStoreWebApp;
using Microsoft.EntityFrameworkCore;
using SessionManagement.Models;
using System.Collections.Generic;

namespace Core.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        public bool Validate(string username, string password)
        {
            using (var context = new RepoCollectionContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Name == username && u.Password == password);
                return user != null && user.Password == password; 
            }
        }
        public void Register(User user)
        {
            using (var context = new RepoCollectionContext())
            {
                try
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
