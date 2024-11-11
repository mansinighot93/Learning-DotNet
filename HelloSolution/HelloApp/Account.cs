using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class Account
    {
        private float balance;
        public float Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public Account(float amount) { 
            balance = amount;
        }
        public void Deposite(float amount)
        {
            balance = balance + amount;
        }
        public void Withdraw(float amount)
        {
            balance = balance - amount;
        }
    }
}
