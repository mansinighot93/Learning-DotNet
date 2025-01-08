using System;
using System.Threading;

namespace ThreadConsole
{
    //Singleton 
    //Single Thread
    //Muti threading
    public class Program
    {
        static void GetData()
        {
            Thread  theThread = Thread.CurrentThread;
            Console.WriteLine("GetData Function ID invoker:" + theThread.ManagedThreadId);
        }

        static void RemoteGetData()
        {
            Thread  theThread = Thread.CurrentThread;
            Console.WriteLine("RemoteGetData Function ID invoker:" + theThread.ManagedThreadId);
        }

        static void Main(string[] args)
        {
            //Primary Thread
            Thread  theThread = Thread.CurrentThread;
            Console.WriteLine("Main Function ID invoker:" + theThread.ManagedThreadId);
            Thread.Sleep(3000);
            Display();
            Console.WriteLine("Hello World");

            //Createing two secondory threaded using .NET SDK
            ThreadStart theDelegate1 = new ThreadStart(GetData);
            Thread theThread1 = new Thread(theDelegate1);
            theThread1.Start();

            
            ThreadStart theDelegate2 = new ThreadStart(RemoteGetData);
            Thread theThread2 = new Thread(theDelegate2);
            theThread2.Start();
        }

        public static void Display()
        {
            Thread  theThread = Thread.CurrentThread;
            Console.WriteLine("Display Function ID invoker:" + theThread.ManagedThreadId);
            Console.WriteLine("Display Funcion");
        }
    }
}
