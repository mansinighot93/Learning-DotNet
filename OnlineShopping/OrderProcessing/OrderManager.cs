
using System;
using System.Data;
using System.Collections.Generic;

namespace OrderProcessing
{
     public  static class OrderManager
    {   
         public static List<Order> GetAll() 
        {
            List<Order> Orders = new List<Order>();
             
            return Orders;
        }

    public static Order GetById(int OrderId)
        {
            Order theOrder=null;
           
            return theOrder;
        }
    public static bool Delete(int OrderId)
        {
            bool status = false;
         
            return status;
        }   
    public static bool Update(Order Order)
        {
            bool status = false;
            
            return status;
        }
    public static bool Insert(Order Order)
        {
            bool status = false;
               
            return status;
        }
  }
}