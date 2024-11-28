using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Catalog;
namespace HelloApp
{
    public class LinqTest
    {
        static void Main(string[] args)
        {
            //will act like console UI
            List<Product> allProducts = BuissnessManager.GetAllProducts();
            List<Product> allSoldOutProduct = BuissnessManager.GetSoldProduct();
            foreach (Product theProduct in allProducts)
            {
                Console.WriteLine(theProduct.Title);
            }
            foreach (Product theProduct in allSoldOutProduct)
            {
                Console.WriteLine(theProduct.Title);
            }
            Console.ReadLine();
        }        
    }
}
