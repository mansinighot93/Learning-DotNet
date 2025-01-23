using System;
using System.Collections.Generic;
using System.Linq;
namespace EStoreWebApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MicroLearning : TransFlower");
            IDBManager dbm=new DBManager();
            bool status = true;
            while(status)
            {
                Console.WriteLine("Choose Option:");
                Console.WriteLine("1.Display Records");
                Console.WriteLine("2.Insert New Records");
                Console.WriteLine("3.Update Existing Records");
                Console.WriteLine("4.Delete Existing Records");
                Console.WriteLine("5.Exit");

                switch(int.Parse(Console.ReadLine()))
                {
                    //Display Products
                    case 1:
                    {
                        List<Product> allProducts=dbm.GetAll();
                        foreach (var product in allProducts)
                        {
                            Console.WriteLine(" Id: {0}, Title: {1}, UnitPrice: {2}, Quantity: {3}",
                                                product.Id,product.Title,product.UnitPrice,
                                                product.Quantity);
                        }
                    }
                    break;
            
                    //Insert new  Product
                    case 2:
                        var newProduct = new Product()
                        {
                            Id = 23,
                            Title = "Rose",
                            Description = "Valentine Flower",
                            UnitPrice = 15,
                            Quantity = 5000
                        };
                        dbm.Insert(newProduct);
                    break;

                // Update existing Product
                case 3:
                {
                    var updateProduct = new Product(){
                        Id = 23,
                        Title = "Jasmine",
                        Description = "Smelling Flower",
                        UnitPrice = 40,
                        Quantity = 4000
                    };

                    dbm.Update(updateProduct);
                }
                break;
            
                // Delete existing Product
                case 4:
                    dbm.Delete(23);
                break;
            
                //Exit from loop
                case 5:
                    status = false;
                break;   
                }
            }
        }
    }
}
