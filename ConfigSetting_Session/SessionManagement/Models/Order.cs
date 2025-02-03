
namespace Core.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public double TotalAmount { get; set; } 
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
