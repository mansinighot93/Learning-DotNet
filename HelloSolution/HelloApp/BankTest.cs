using Banking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    public class BankTest
    {
        static void Main(string[] args)
        {
            Account a1 = new Account(56000);
            Console.WriteLine("1.Withdraw");
            Console.WriteLine("2.Deposite");
            int option = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enetr Amount:");
            float amount = float.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                    {
                        a1.Withdraw(amount);
                    }
                    break;
                case 2:
                    { 
                        a1.Deposite(amount);
                    }
                    break;
            }
            float balance = a1.Balance;
            Console.WriteLine("Your Remaining Balance :{0}",balance);
            
            Console.WriteLine(a1);
            Console.ReadLine();
        }
    }
}
