using Core.Models;
using SessionManagement.Models;
using System.Collections.Generic;

namespace Core.Repositories.Interfaces
{
    public interface IAuthRepository
    {
        public User Validate(string username,string password);
        public void Register(User user);
        public User ForgotPassword(string username, string newPassword, string confirmPassword);

    }
}
