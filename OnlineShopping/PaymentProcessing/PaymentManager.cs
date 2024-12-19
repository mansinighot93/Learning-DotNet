
using System;
using System.Data;
using System.Collections.Generic;

namespace PaymentProcessing
{
     public  static class PaymentManager
    {   
         public static List<Payment> GetAll() 
        {
            List<Payment> payments = new List<Payment>();
             
            return payments;
        }

    public static Payment GetById(int paymentId)
        {
            Payment thePayment=null;
           
            return thePayment;
        }
    public static bool Delete(int paymentId)
        {
            bool status = false;
         
            return status;
        }   
    public static bool Update(Payment payment)
        {
            bool status = false;
            
            return status;
        }
    public static bool Insert(Payment payment)
        {
            bool status = false;
               
            return status;
        }
  }
}