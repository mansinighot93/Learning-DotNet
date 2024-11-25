using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking;
using HelloApp;
namespace HelloApp
{
    public class EventDemoTest
    {
        public static class Goverment
        {
            public static void PayIncomTax()
            {
                Console.WriteLine("15% income tax is getting deducted from your account");
            }
        }
        public static class HDFCBank
        {
            public static void BlockAccount()
            {
                Console.WriteLine("Your Account has been blocked due to insufficient funds");
            }
            public static void SendEmail()
            {
                Console.WriteLine("Email Send");
            }
        }
        static void Main(string[] args)
        {
            Account a1 = new Account(45000);

            //events are getting registerd with event handler
            a1.underbalnce += new AccountHandler(HDFCBank.BlockAccount);//register event handler
            a1.underbalnce += new AccountHandler(HDFCBank.SendEmail);//register event handler
            a1.overbalnce += new AccountHandler(Goverment.PayIncomTax);//register event handler

            Console.WriteLine("Initial Balnce:{0}",a1.Balance);
            Console.WriteLine(a1.Balance);
            Console.WriteLine("Enter Amount to Deposite:");
            float amount1 = float.Parse(Console.ReadLine());

            a1.Deposite(amount1);
            Console.WriteLine("Net Balnce after operation:");
            Console.WriteLine(a1.Balance);

            Console.WriteLine("Enter Amount to Withdraw:");
            float amount2 = float.Parse(Console.ReadLine());

            a1.Withdraw(amount2);
            Console.WriteLine("Net Balnce after operation:");
            Console.WriteLine(a1.Balance);
            Console.ReadLine();
        }
    }
}
