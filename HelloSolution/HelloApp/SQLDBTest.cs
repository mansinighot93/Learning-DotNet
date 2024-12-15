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

            bool status = false;
            Product theProduct = BuissnessManager.GetProduct(2);
            theProduct.UnitPrice = 99;
            theProduct.Qunatity = 150;
            status = BuissnessManager.UpdateProduct(theProduct);
            //status = BuissnessManager.DeleProduct(5);
            IEnumerable<Product> allProducts = BuissnessManager.GetAllProducts();
            foreach (Product product in allProducts)
            {
                Console.WriteLine("Title = {0} ,Quantity = {1} , Description = {2} ", product.title,product.Qunatity,product.Description);
            }
        }
    }
}
