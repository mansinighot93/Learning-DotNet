using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Eventhandler
{
    
    public delegate void EventHandler();
    public class Event
    {
        private float balance;
        public event EventHandler underbalnce;
        public event EventHandler overbalnce; 
        public void Monitoring()
        {
            if(balance < 5000)
            {
                underbalnce();
            }
            else if(balance >=25000)
            {
                overbalnce();
            }
        }
    }
}
