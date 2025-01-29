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
        public User Validate(string username, string password)
        {
            using (var context = new RepoCollectionContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Email == username && u.Password == password);
                return user; 
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
        public User ForgotPassword(string username, string newPassword, string confirmPassword)
        {
            if (newPassword != confirmPassword)
            {
                return null;
            }

            using (var context = new RepoCollectionContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Email == username);

                if (user == null)
                {
                    return null;
                }

                user.Password = newPassword;
                context.SaveChanges(); 
                return user; 
            }
        }
    }
}

