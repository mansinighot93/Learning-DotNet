using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR;
namespace ConsoleApp1
{
    class GCTest
    {
        static void Main(string[] args)
        {
            //Determinstic Finalization is always handled by garbage collection--->explicitly disposing resources by main thread
            //Inderministic Finalization ---> calling destructor for releasing resources by GC
            using (Person thePerson = new Person("Manasi", "Nighot", new DateTime(2003, 06, 21)))
            {
                for (int i = 0; i < 5000; i++)
                {
                    Console.WriteLine(thePerson);
                }
                // GC.SuppressFinalize(thePerson);//blocks calling destructor
                //GC is Garbage Collection class is singleton
                // GC.WaitForPendingFinalizers();
                //  GC.Collect();//make to the request of garbage collector
            }
            Console.ReadLine();
        }
    }
}
