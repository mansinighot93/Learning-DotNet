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
        List<Product> allProducts = BuissnessManager.GetAllProducts();
        foreach(Product theProduct in allProducts)
        {
            Console.WriteLine(theProduct.Title);
        }
        Console.ReadLine();
    }
}
