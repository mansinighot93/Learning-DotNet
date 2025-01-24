using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace BIApp.Models
{
    public class SalesRepository
    {
        public List<Product> products = new List<Product>();
        public List<Customer> customers = new List<Customer>();
        public SalesRepository()
        {

        }
        private List<Product> FillProducts()
        {
            products.Add(new Product()
            {
                Title = "Gerbera",
                Description = "Wedding Flower",
                Quantity = 855,
                UnitPrice = 7898,
                Rating = 889
            });
            products.Add(new Product()
            {
                Title = "Lily",
                Description = "Wedding Flower",
                Quantity = 855,
                UnitPrice = 7898,
                Rating = 889
            });
            products.Add(new Product()
            {
                Title = "Jasmine",
                Description = "Wedding Flower",
                Quantity = 855,
                UnitPrice = 7898,
                Rating = 889
            });
            products.Add(new Product()
            {
                Title = "Marigold",
                Description = "Wedding Flower",
                Quantity = 855,
                UnitPrice = 7898,
                Rating = 889
            });
            return products;
        }
        private List<Customer> FillCustomers()
        {
            customers.Add(new Customer()
            {
                Name = "Rajan PAtil",
                Age = 28,
                Location = "Mumbai",
            });
            customers.Add(new Customer()
            {
                Name = "Mangesh More",
                Age = 27,
                Location = "Chenani",
            });
            customers.Add(new Customer()
            {
                Name = "Shiv Kumar",
                Age = 23,
                Location = "Nashik",
            });
            customers.Add(new Customer()
            {
                Name = "Rajan PAtil",
                Age = 28,
                Location = "Mumbai",
            });
            return customers;
        }
    }
}