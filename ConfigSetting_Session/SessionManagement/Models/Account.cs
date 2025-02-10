using Core.Models;
namespace Core.Models
{
    public class Account
    {
        public int AccountId { get; set; }
        public string AccountNumber { get; set; }
        public string BankName { get; set; }
        public string IFSCCode { get; set; }
        public decimal Balance { get; set; }
        public User User { get; set; }
        public int UserID { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
        public ICollection<Card> Cards { get; set; }

        // Deposit Method
        public void Deposit(decimal amount)
        {
            if (amount > 0)
                Balance += amount;
        }

        // Withdraw Method
        public bool Withdraw(decimal amount)
        {
            if (amount > 0 && Balance >= amount)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
    }
}

