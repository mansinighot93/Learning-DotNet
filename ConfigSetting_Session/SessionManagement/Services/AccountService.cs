using Core.Models;
using Core.Repositories.Interfaces;
using Core.Services.Interfaces;
using SessionManagement.Models;
using System.Collections.Generic;

namespace Core.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepo;
        public AccountService(IAccountRepository accountRepo)
        {
            _accountRepo = accountRepo;
        }
        public List<Account> GetAll() => _accountRepo.GetAll();
        public Account GetById(int id) => _accountRepo.GetById(id);
        public void Insert(Account account) => _accountRepo.Insert(account);
        public void Update(Account account) => _accountRepo.Update(account);
        public void Delete(int id) => _accountRepo.Delete(id);
    }
}