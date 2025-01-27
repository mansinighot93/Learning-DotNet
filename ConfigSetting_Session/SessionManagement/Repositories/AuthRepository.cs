using Core.Models;
using Core.Repositories.Interfaces;
using EStoreWebApp;
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
                var user = context.Login.FirstOrDefault(u => u.Username == username && u.Password == password);
                return user != null && user.Password == password; 
            }
        }
        public void Insert(Register register)
        {
            using (var context = new RepoCollectionContext())
            {
                try
                {
                    context.Register.Add(register);
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
