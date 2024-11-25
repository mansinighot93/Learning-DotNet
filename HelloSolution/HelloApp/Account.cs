using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public delegate void AccountHandler();
    public class Account
    {
        private float balance;
        public event AccountHandler underbalnce;
        public event AccountHandler overbalnce;
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
            Monitor();

        }
        public void Withdraw(float amount)
        {
            balance = balance - amount;
            Monitor();
        }

        public void Monitor()
        {
            if (balance < 5000)
            {
                underbalnce();
            }
            else if(balance >= 25000)
            {
                overbalnce();
            }
        }
        //Always override to convert object state into string
        public override string ToString() { 
            return balance.ToString();
        }
    }
}
