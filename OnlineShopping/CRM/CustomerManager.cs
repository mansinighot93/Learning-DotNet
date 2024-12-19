
using System;
using System.Data;
using System.Collections.Generic;

namespace CRM
{
     public  static class CustomerManager
    {
         public static List<Customer> GetAll() 
        {
            List<Customer> customers = new List<Customer>();
             
            return customers;
        }

        public static Customer GetById(int customerId)
        {
            Customer theCustomer=null;
           
            return theCustomer;
        }
        public static bool Delete(int customerId)
        {
            bool status = false;
        
            return status;
        }   
        public static bool Update(Customer customer)
        {
            bool status = false;
            
            return status;
        }
        public static bool Insert(Customer customer)
        {
            bool status = false;
            
            
            return status;
        }
  }
}