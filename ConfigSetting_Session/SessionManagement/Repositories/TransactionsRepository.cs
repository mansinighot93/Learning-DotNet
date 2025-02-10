using Core.Models;
using Core.Repositories.Interfaces;
using SessionManagement.Models;
using System.Collections.Generic;

namespace Core.Repositories
{
    public class TransactionsRepository : ITransactionsRepository
    {
        public List<Transaction> GetAll()
        {
            using (var context = new RepoCollectionContext())
            {
                var transaction = from prod in context.Transactions select prod;
                return transaction.ToList<Transaction>();
            }
        }

        public Transaction GetById(int id)
        {
            using (var context = new RepoCollectionContext())
            {
                var transaction = context.Transactions.Find(id);
                return transaction;
            }
        }

        public void Insert(Transaction transaction)
        {
            using (var context = new RepoCollectionContext())
            {
                context.Transactions.Add(transaction);
                context.SaveChanges();
            }
        }

        public void Update(Transaction transaction)
        {
            using (var context = new RepoCollectionContext())
            {
                var theTransaction = context.Transactions.Find(transaction.Id);
                theTransaction.Amount = transaction.Amount;
                theTransaction.ToAccountId = transaction.ToAccountId;
                theTransaction.FromAccountId = transaction.FromAccountId;
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new RepoCollectionContext())
            {
                context.Transactions.Remove(context.Transactions.Find(id));
                context.SaveChanges();
            }
        }
    }
}

