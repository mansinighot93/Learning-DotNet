using Core.Models;
using SessionManagement.Models;
using System.Collections.Generic;

namespace Core.Repositories.Interfaces
{
    public interface ITransactionsRepository
    {
        public List<Transaction> GetAll();
        public Transaction GetById(int id);
        public void Insert(Transaction transaction);
        public void Update(Transaction transaction);
        public void Delete(int id);
    }
}
