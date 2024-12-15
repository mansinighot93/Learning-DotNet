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
            for (int i = 0; i < 5000; i++)
            {
                Person thePerson = new Person("MAnasi", "Nighot", new DateTime(2003, 06, 21));
                Console.WriteLine(thePerson);
            }
            Console.ReadLine();
        }
    }
}
