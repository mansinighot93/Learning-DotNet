using System;
//Single Responsibility Principle (SRP)
/*
    A class should have one and only one reason to change, 
    meaning that a class should have only one job. 
*/

namespace SRP
{
    public class Data{   }
    public class BusinessServer
    {
        public void Get(Data message)
        {
        //Event Handling Logic on Get Message from Queue
        }
    
        public void Process(Data message)
        {
        //Check if Message Server  is  Listening
        //Process the Message
        }
    
        public void Dispatch(Data message)
        {
            //Event Handling Logic on Dispath Message to Dispatcher
        }
    }
    
    //Contract:
    // they are used for loosely coupled architecture
    // defines rules
    // defines specification

    public interface IService
        {
            void Get(Data message);
            void Process(Data message);
            void Dispatch(Data message);
        }

    // act like subject Matter expert

public class PaymentServiceProvider:IService{
    public void Get(Data message)
    { }
    
    public void Process(Data message)
    {
        //Process Payment Processing
    }
    public void Dispatch(Data message)
    {    }
}
    public class DeliveryServiceProvider : IService
    {
        public void Get(Data message)
        {        }
    
        public void Dispatch(Data message)
        {        }

        public void Process(Data message)
        {        }
    }

   public class BillingServiceProvider : IService
    {
        public void Get(Data message)
        {
        }
    
        public void Dispatch(Data message)
        {
        }

        public void Process(Data message)
        {
        }
    }

    // act like a manager
    public class Server
    {
        IService service;
    
        public Server(IService svc)
        {
            this.service = svc;
        }
        public void Get(Data message)
        {
            service.Get(message);
        }
        public void Process(Data message)
        {
            service.Process( message);
        }
        public void Dispatch(Data message)
        {
            service.Dispatch(message);
        }
    }

    /* class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Single Responsibility Principle (SRP)");
            IService service=new PaymentServiceProvider();
         
            Server mgr=new Server(service);
            Data message =new Data();
            mgr.Process(message);
        }
    }  */
}
