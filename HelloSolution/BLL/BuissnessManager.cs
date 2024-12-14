using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalog;

namespace BLL
{
    public static class BuissnessManager
    {
        public static List<Product> GetAllProducts()
        {
            List<Product> allProducts = new List<Product>();
            allProducts.Add(new Product(id: 1,title: "Gerbera",description: "Wedding Flower", unitPrice: 500,quantity: 12));
            allProducts.Add(new Product(id: 2, title: "Rose", description: "Valentine Flower", unitPrice: 1500, quantity: 32));
            allProducts.Add(new Product(id: 3, title: "Lotus", description: "Worship Flower", unitPrice: 50, quantity: 0));
            allProducts.Add(new Product(id: 4, title: "Aster", description: "Wedding Flower", unitPrice: 20, quantity: 0));

            return allProducts;
        }
        public static List<Product> GetSoldProducts()
        {
            //Apply filter 
            //Apply some buissness query
            //LINQ:Language Integrated Query
            //Var kwyword is dynamic query from C# 
            List<Product> products = GetAllProducts();
            var soldOutProducts = from product in products select product;
            return soldOutProducts as List<Product>;
            //return products;
        }
    }
}
