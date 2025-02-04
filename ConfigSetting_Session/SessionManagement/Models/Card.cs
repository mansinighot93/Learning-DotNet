namespace Core.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string CardType { get; set; }
        public int CardNumber { get; set; }
        public Account Accounts { get; set; }
        public int AccountId { get; set; }
    }
}
