using BLL;
using Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
namespace HelloApp
{
    public class LinqTest
    {
        static void Main(string[] args)
        {

            //will act like console UI
            IEnumerable<Product> allProducts = BuissnessManager.GetAllProducts();
            //List<Product> allSoldOutProduct = BuissnessManager.GetSoldProducts();
            foreach (Product theProduct in allProducts)
            {
                Console.WriteLine(theProduct.Title + " " + theProduct.Qunatity);
            }
            /* foreach (Product theProduct in allSoldOutProduct)
             {
                 Console.WriteLine(theProduct.Title);
             }*/

            // Specify the data source.
            int[] scores = new int[] { 97, 92, 81, 60 };

            // Define the query expression.
            IEnumerable<int> scoreQuery = from score in scores
                                          where score > 80
                                          select score;

            // Execute the query.
            foreach (int score in scoreQuery)
            {
                Console.WriteLine(score);
            }

            List<int> numbers = new List<int> { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // The query variables can also be implicitly typed by using var

            // Query #1.
            IEnumerable<int> filteringQuery = from num in numbers
                                              where num < 3 || num > 7
                                              select num;
            Console.WriteLine("Show  number which are not in between 3 and 7");
            foreach (int score in filteringQuery)
            {
                Console.WriteLine(score);
            }

            // Query #2.
            IEnumerable<int> orderingQuery = from num in numbers
                                             where num < 3 || num > 7
                                             orderby num ascending //descending
                                             select num;
            Console.WriteLine("Show number which are not in between 3 and 7 ascending order");

            foreach (int score in orderingQuery)
            {
                Console.WriteLine(score);
            }
            /* same using var keyword
             var allSoldOutProducts = from product in allProducts
                                                      where product.Qunatity == 0
                                                      select product;

            IEnumerable<Product> allSoldOutProducts = from product in allProducts
                                                      where product.Qunatity < 5000
                                                      select product;*/

            IEnumerable<Product> allSoldOutProducts = BuissnessManager.GetSoldOutProducts();
            Console.WriteLine("Show only those product title which are not sold out");
            foreach (Product theProduct in allSoldOutProducts)
            {
                Console.WriteLine(theProduct.title + "," +theProduct.Qunatity);
            }
         
            Console.ReadLine();
        }
    }
}
