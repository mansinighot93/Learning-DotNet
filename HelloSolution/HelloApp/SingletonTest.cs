using Catalog;
using CRM;
using Membership;
using ShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    public class SingletonTest
    {
        static void Main(string[] args)
        {
            Customer mgr1, mgr2;
            mgr1 = Customer.GetCustomer();
            mgr2 = Customer.GetCustomer();
            Console.WriteLine(mgr1);

            Product product1 = new Product(1, "Rose", "Valentine Flower", 4500, 20);
            Product product2 = new Product(2, "Gerbera", "Weeding Flower", 450, 10);
            Item item1 = new Item(product1, 34);
            Item item2 = new Item(product2, 56);

            Cart cart1 = new Cart();

        }
    }
}
