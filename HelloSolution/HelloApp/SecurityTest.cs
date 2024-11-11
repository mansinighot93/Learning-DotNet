using Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    public class SecurityTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Login Demo");
            Console.WriteLine("Enetr User ID:");
            string userId = Console.ReadLine();

            Console.WriteLine("Enetr Password:");
            string password = Console.ReadLine();

            bool status = AccountManager.Login(userId, password);
            if (status)
            {
                Console.WriteLine("Welcome ...");
            }
            else
            {
                Console.WriteLine("Invalid User..");
            }


            Console.WriteLine("Customer Registration");
            Console.WriteLine("Full Name:");
            string fullName = Console.ReadLine();

            Console.WriteLine("Enter You Email:");
            string email = Console.ReadLine();

            Console.WriteLine("Enter Your Conatct Number:");
            string contactNumber = Console.ReadLine();

            Console.WriteLine("Enter Your Location:");
            string location = Console.ReadLine();

            bool statuss = AccountManager.Register(userId, password,fullName, email, contactNumber, location);
            if(statuss) {
                Console.WriteLine("Test Passed...");
            }
            else
            {
                Console.WriteLine("Test Failed..");
            }
            Console.ReadLine();
        }
    }
}
