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
    }
}

