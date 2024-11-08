using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstConsoleApp;

namespace FirstConsoleApp
{
    //
    public class Employee : Person
    {
        private int _id;
        private double _da;
        private double _hra;
        private double _dayworking;
        public Employee(string _firstname,string _lastname,int _age,int _id,double _da,double _hra,double _dayworking) : base(_firstname,_lastname,_age)
        {
            this._id = _id;
            this._da = _da;
            this._hra = _hra;
            this._dayworking = _dayworking;
        }
        public Employee()
        {
            this._id = 1;
            this._hra = 20.00;
            this._da = 21.30;
            this._dayworking = 56.5;
        }

        public void show()
        {
            base.show();
            Console.WriteLine(this._id + " , " + this._hra + " , " + this._da + " , " + this._dayworking);
        }
    }
}
