using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class Customers
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string ContactNumber { get; set; }
        public required string Email { get; set; }
        public required string Location { get; set; }
        public required int Age { get; set; }
    }
}
