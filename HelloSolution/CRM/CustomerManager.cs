using System;
using System.Data;
using System.Collections.Generic;
using CRM;
using System.Linq;

namespace CRM
{
    public static class CustomerManager
    {
        public static List<Customers> GetAllCustomers()
        {
            List<Customers> customers = new List<Customers>();
            customers = GetAllCustomersFromDatabase();
            return customers;
        }
        public static List<Customers> GetAllCustomersFromDatabase()
        {
            List<Customers> allCustomers = CustomerDBManager.GetAll();
            return allCustomers;
        }

        public static Customers GetById(int customerId)
        {
            List<Customers> customers = GetAllCustomers();
            Customers theCustomer = customers.FirstOrDefault(p => p.Id == customerId);
            return theCustomer;
        }
        public static bool Delete(int customerId)
        {
            bool status = false;
            status = CustomerDBManager.Delete(customerId);
            return status;
        }
        public static bool Update(Customers customer)
        {
            bool status = false;
            status = CustomerDBManager.Update(customer);
            return status;
        }
        public static bool Insert(Customers customer)
        {
            bool status = false;
            status = CustomerDBManager.Insert(customer);
            return status;
        }
    }
}