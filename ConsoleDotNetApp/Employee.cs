using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleDotNetApp;

namespace ConsoleDotNetApp
{
    //
    public class Employee : Person
    {
        private int _id;
        private double _da;
        private double _hra;
        private double _dayworking;
        public Employee()
        {
            this._id = 1;
            this._hra = 20.00;
            this._da = 21.30;
            this._dayworking = 56.5;
        }

        public void show()
        {
            Console.WriteLine(this._id + " , " + this._hra + " , " + this._da + " , " + this._dayworking);
        }
    }
    public class Employee2 : Employee {
       private string _name;
       private string _email;
       private long _contactnumber;
        public Employee2(string _name,string _email,long _contactnumber) {
            this._name = _name;
            this._email = _email;
            this._contactnumber = _contactnumber;
        }
        public void show()
        {
            Console.WriteLine(this._name + " , " + this._email + " , " + this._contactnumber);
        }
    }

}
