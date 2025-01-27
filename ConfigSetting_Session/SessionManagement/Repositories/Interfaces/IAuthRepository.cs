using Core.Models;
using SessionManagement.Models;
using System.Collections.Generic;

namespace Core.Repositories.Interfaces
{
    public interface IAuthRepository
    {
        public bool Validate(string username,string password);
        public void Insert(Register register);

    }
}
