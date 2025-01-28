
namespace Core.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public long ContactNumber { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

    }
}
