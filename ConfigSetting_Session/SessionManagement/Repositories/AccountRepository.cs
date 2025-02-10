using Core.Models;
using Core.Repositories.Interfaces;
using SessionManagement.Models;
using System.Collections.Generic;

namespace Core.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public List<Account> GetAll()
        {
            using (var context = new RepoCollectionContext())
            {
                var account = from prod in context.Accounts select prod;
                return account.ToList<Account>();
            }
        }

        public Account GetById(int id)
        {
            using (var context = new RepoCollectionContext())
            {
                var account = context.Accounts.Find(id);
                return account;
            }
        }

        public void Insert(Account account)
        {
            using (var context = new RepoCollectionContext())
            {
                context.Accounts.Add(account);
                context.SaveChanges();
            }
        }

        public void Update(Account account)
        {
            using (var context = new RepoCollectionContext())
            {
                var theAcc = context.Accounts.Find(account.AccountId);
                theAcc.AccountNumber = account.AccountNumber;
                theAcc.BankName = account.BankName;
                theAcc.IFSCCode = account.IFSCCode;
                theAcc.Balance = account.Balance;
                theAcc.UserID = account.UserID;
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new RepoCollectionContext())
            {
                context.Accounts.Remove(context.Accounts.Find(id));
                context.SaveChanges();
            }
        }
    }
}

