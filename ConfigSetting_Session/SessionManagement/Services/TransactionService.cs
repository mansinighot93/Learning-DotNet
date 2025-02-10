using Core.Models;
using Core.Repositories.Interfaces;
using Core.Services.Interfaces;
using SessionManagement.Models;
using System.Collections.Generic;

namespace Core.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionsRepository _transRepo;
        public TransactionService(ITransactionsRepository transRepo)
        {
            _transRepo = transRepo;
        }
        public List<Transaction> GetAll() => _transRepo.GetAll();
        public Transaction GetById(int id) => _transRepo.GetById(id);
        public void Insert(Transaction transaction) => _transRepo.Insert(transaction);
        public void Update(Transaction transaction) => _transRepo.Update(transaction);
        public void Delete(int id) => _transRepo.Delete(id);
    }
}