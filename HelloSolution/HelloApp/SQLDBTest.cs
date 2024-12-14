using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Catalog;

namespace HelloApp
{
    public class SQLDBTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Database Connectivity Program");
            IEnumerable<Product> allProducts = BuissnessManager.GetAllProducts();
            foreach (Product product in allProducts)
            {
                Console.WriteLine("Title = {0} ,Quantity = {1} , Description = {2} ", product.title,product.Qunatity,product.Description);
            }
        }
    }
}
