using System;

//Interface Segregation Principle (ISP)
namespace ISP
{
    public interface IOrder
    {
        void AddToCart();
    }
 
    public interface IOnlineOrder
    {
        void ProcessThroghPaymentGateway();
    }
 
    public class OnlineOrder : IOrder, IOnlineOrder
    {
        public void AddToCart()
        {
            //Do Add to Cart
        }
    
        public void ProcessThroghPaymentGateway()
        {
            //process through credit card, debit cart, UPI
            //NetBanking
        }
    }
 
    public class OfflineOrder : IOrder
    {
        public void AddToCart()
        {
            //Do Add to Cart
        }
    }
}