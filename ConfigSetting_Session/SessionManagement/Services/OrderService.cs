using Core.Models;
using Core.Repositories.Interfaces;
using Core.Services.Interfaces;
using System.Collections.Generic;

namespace Core.Services
{
    public class OrderService : IOrderService 
    {
        private readonly IOrderRepository _orderRepo;
        public OrderService(IOrderRepository orderRepo)
        {
            _orderRepo = orderRepo;
        }
        public List<Order> GetAll() => _orderRepo.GetAll();
        public Order GetById(int id)=>_orderRepo.GetById(id);
        public void Insert(Order order) => _orderRepo.Insert(order);

    
    }
}