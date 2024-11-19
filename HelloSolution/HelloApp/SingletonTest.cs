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
{//Singleton pattern
 //allow only one instance of a class to be created
 //1.define private constructor:
 //private static class_name _ref = null;

    //2.keep slef refernce as satatic variable to class
    //3.create instance of class verifying refernce nullability with the help of static method
    //public static class_name getmanager(){ if(_ref == null)
    //_ref = new class_name();return _ref;
    //else{
    //return _ref;}}
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
            List<Item> cartItem = new List<Item>();
            DateTime ordDate = DateTime.Now;
            Customer cust1 = Customer.GetCustomer();
           

            

        }
    }
}
