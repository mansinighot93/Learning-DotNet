using Core.Models;
using SessionManagement.Models;
using System.Collections.Generic;

namespace Core.Repositories.Interfaces
{
    public interface IAccountRepository
    {
        public List<Account> GetAll();
        public Account GetById(int id);
        public void Insert(Account account);
        public void Update(Account account);
        public void Delete(int id);
    }
}
