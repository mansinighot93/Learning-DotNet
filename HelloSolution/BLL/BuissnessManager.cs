using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalog;
using DAL;

namespace BLL
{
    public static class BuissnessManager
    {
        public static List<Product> GetDataFromDatabase()
        {
            List<Product> allProducts = new List<Product>();
            //Invoke backend data into .NET application 
            //Needed database connectivity
            //You need to use:
            //1.Ado.NET Object Model(JDBC) (Activec Data Object or
            //2. Entity Framework (Hibernet)

            //Connect to database
            //Qurey against database using SQL
            //get resultset from Query Processing
            //Create List of Products from resultset
            //return list of products

            return allProducts;
            
        }
        public static IEnumerable<Product> GetAllProducts()
        {
            IEnumerable<Product> allProducts = CatalogDBManager.GetAllProductUsingDisconnected();
            return allProducts;

            #region HardCode Way
            /*
            List<Product> allProducts = new List<Product>();
            allProducts.Add(new Product(id: 1,title: "Gerbera",description: "Wedding Flower", unitPrice: 500,quantity: 12));
            allProducts.Add(new Product(id: 2, title: "Rose", description: "Valentine Flower", unitPrice: 1500, quantity: 32));
            allProducts.Add(new Product(id: 3, title: "Lotus", description: "Worship Flower", unitPrice: 50, quantity: 0));
            allProducts.Add(new Product(id: 4, title: "Aster", description: "Wedding Flower", unitPrice: 20, quantity: 0));
            */
            #endregion
        }

        public static IEnumerable<Product> GetSoldOutProducts()
        {
            //Apply filter 
            //Apply some buissness query
            //LINQ:Language Integrated Query
            //Var kwyword is dynamic query from C# 
            IEnumerable<Product> products = GetAllProducts();
                var soldOutProducts = from product in products 
                                      where product.Qunatity == 0
                                      select product;
                return soldOutProducts;
        }

        public static Product GetProduct(int id)
        {
            return CatalogDBManager.GetProductByID(id);
        }

        public static bool UpdateProduct(Product theProduct)
        {
            return CatalogDBManager.Update(theProduct);
        }
        public static bool DeleteProduct(int id)
        {
            return CatalogDBManager.Delete(id);
        }
    }
}

