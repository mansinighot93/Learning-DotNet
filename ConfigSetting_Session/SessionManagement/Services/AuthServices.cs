using Core.Models;
using Core.Repositories.Interfaces;
using Core.Services.Interfaces;
using SessionManagement.Models;
using System.Collections.Generic;

namespace Core.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _authRepo;
        public AuthService(IAuthRepository authRepo)
        {
            _authRepo = authRepo;
        }
        public User Validate(string username,string password) => _authRepo.Validate(username,password);
        public void Register(User user) => _authRepo.Register(user);

    }
}