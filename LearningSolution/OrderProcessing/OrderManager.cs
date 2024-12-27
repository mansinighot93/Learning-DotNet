using System;
using System.Data;
using System.Collections.Generic;
using OrderProcessing;

namespace OrderProcessing
{
    public static class OrderManager
    {
        public static List<Orders> GetAllOrder()
        {
            List<Orders> orders = new List<Orders>();
            orders=GetAllOrdersFromDatabase();
            return orders;
        }
        public static List<Orders> GetAllOrdersFromDatabase()
        {
            List<Orders> allorders = OrderDBManager.GetAll();
            return allorders;
        }

        public static Orders GetById(int orderId)
        {
            List<Orders> order = GetAllOrder();
            Orders theOrder = order.FirstOrDefault(p => p.Id == orderId);
            return theOrder;
        }
        public static bool Delete(int orderId)
        {
            bool status = false;
            status=OrderDBManager.Delete(orderId);
            return status;
        }
        public static bool Update(Orders order)
        {
            bool status=false;
            status=OrderDBManager.Update(order);
            return status;
        }
        public static bool Insert(Orders order)
        {
            bool status = false;
            status=OrderDBManager.Insert(order);
            return status;
        }
    }
}