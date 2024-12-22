
using System;
using System.Data;
using System.Collections.Generic;

namespace CRM
{
    public static class CustomerManager
    {
        public static List<Customers> GetAll()
        {
            List<Customers> customers = new List<Customers>();
            return customers;
        }

        public static Customers GetById(int customerId)
        {
            Customers theCustomer = null;
            return theCustomer;
        }
        public static bool Delete(int customerId)
        {
            bool status = false;
            return status;
        }
        public static bool Update(Customers customer)
        {
            bool status = false;
            return status;
        }
        public static bool Insert(Customers customer)
        {
            bool status = false;
            return status;
        }
    }
}