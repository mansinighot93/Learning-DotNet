using Core.Models;
using Core.Repositories.Interfaces;
using SessionManagement.Models;using System.Collections.Generic;

namespace Core.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public List<Order> GetAll()
        {
            using(var context = new RepoCollectionContext())
            {
                var orders = from prod in context.Orders select prod;
                return orders.ToList<Order>();
            }
        }
        public Order GetById(int id)
        {
            using(var context = new RepoCollectionContext())
            {
                var order = context.Orders.Find(id);
                return order;
            }
        }
        public void Insert(Order order)
        {
            using (var context = new RepoCollectionContext())
            {
                context.Orders.Add(order);
                
            }
        }
    }
}
