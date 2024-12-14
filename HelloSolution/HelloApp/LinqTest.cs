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
            //List<Product> allSoldOutProduct = BuissnessManager.GetSoldProducts();
            foreach (Product theProduct in allProducts)
            {
                Console.WriteLine(theProduct.Title);
            }
            /* foreach (Product theProduct in allSoldOutProduct)
             {
                 Console.WriteLine(theProduct.Title);
             }*/

            // Specify the data source.
            int[] scores = {97, 92, 81, 60};

            // Define the query expression.
            IEnumerable<int> scoreQuery = from score in scores
                                          where score > 80
                                          select score;

            // Execute the query.
            foreach (int score in scoreQuery)
            {
                Console.Write(score);
            }


            Console.ReadLine();
        }        
    }
}
