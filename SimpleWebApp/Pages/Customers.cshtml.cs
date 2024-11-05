using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SimpleWebApp.Models;

namespace SimpleWebApp.Pages
{
    public class CustomersModel : PageModel
    {
        public List<Customer> Customers { get; set; }
        public void OnGet()
        {
            Customers = new List<Customer>();
            Customers.Add(new Customer { Name = "Chirag patil", Email = "chirag.patil@gmail.com", ContactNumber = "8776456789" });
            Customers.Add(new Customer { Name = "Manish Varma", Email = "chirag.patil@gmail.com", ContactNumber = "8776456789" });
            Customers.Add(new Customer { Name = "Ketan Sali", Email = "chirag.patil@gmail.com", ContactNumber = "8776456789" });
            Customers.Add(new Customer { Name = "Chirag Nene", Email = "chirag.patil@gmail.com", ContactNumber = "8776456789" });
            Customers.Add(new Customer { Name = "Pooja patil", Email = "chirag.patil@gmail.com", ContactNumber = "8776456789" });
            Customers.Add(new Customer { Name = "Kalpana Sharma", Email = "chirag.patil@gmail.com", ContactNumber = "8776456789" });
            Customers.Add(new Customer { Name = "Pramod Patel", Email = "chirag.patil@gmail.com", ContactNumber = "8776456789" });
        }
    }
}
