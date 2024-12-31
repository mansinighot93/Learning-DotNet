using System;

namespace OrderProcessing
{
    public class Orders
    {
        public required int Id {get;set;}
        public required DateTime OrderDate {get;set;}
        public required string Status {get;set;}
        public required double TotalAmount {get;set;}
    }
}