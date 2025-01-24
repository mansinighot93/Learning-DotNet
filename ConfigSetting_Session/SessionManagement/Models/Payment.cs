using System;
using  Core.Models;

namespace Core.Models
{
    public class Payment
    {
        public int PaymentId {get;set;}
        public Order theOrder {get;set;}
        
        public Payment()
        {
            
        }
    }
}