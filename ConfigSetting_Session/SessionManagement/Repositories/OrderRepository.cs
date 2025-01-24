using Core.Models;
using Core.Repositories.Interfaces;
using SessionManagement.Models;using System.Collections.Generic;

namespace Core.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public List<Order> GetAll()
        {
            //In a real project, this is where you would call your database/datastore for this info
            // List<Flower> items = new List<Flower>()
            // {
            //     new Flower()
            //     {
            //         ID = 14,
            //         Name = "Summer Breeze Flower Box",
            //         SalePrice = 4.99M,
            //         UnitPrice = 1.69M,
            //         Quantity = 43
            //     },
            //     new Flower()
            //     {
            //         ID = 3,
            //         Name = "Yellow Mellow Sunshine Bouquet",
            //         SalePrice = 4.89M,
            //         UnitPrice = 1.13M,
            //         Quantity = 319
            //     },
            //     new Flower()
            //     {
            //         ID = 18,
            //         Name = "Sunshine Floral Ecstasy",
            //         SalePrice = 5.69M,
            //         UnitPrice = 0.47M,
            //         Quantity = 319
            //     },
            //     new Flower()
            //     {
            //         ID = 19,
            //         Name = "Red Rose Beautiful Bunch",
            //         SalePrice = 6.19M,
            //         UnitPrice = 0.59M,
            //         Quantity = 252
            //     },
            //     new Flower()
            //     {
            //         ID = 1,
            //         Name = "Dreamy Hues",
            //         SalePrice = 5.59M,
            //         UnitPrice = 1.12M,
            //         Quantity = 217
            //     }
            // };
            // return items;
            using(var context = new RepoCollectionContext())
            {
                var orders = from prod in context.Order select prod;
                return orders.ToList<Order>();
            }
        }
        public Order GetById(int id)
        {
            using(var context = new RepoCollectionContext())
            {
                var order = context.Order.Find(id);
                return order;
            }
        }
        

    }
}
