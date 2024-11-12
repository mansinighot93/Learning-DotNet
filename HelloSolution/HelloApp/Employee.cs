using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    public class Employee : Person
    {
        public Employee() :base()
        {

        }
        public Employee(string fname,string lname,DateTime bdate,int id,string dept,float bSalary,int daysWorked):base(fname,lname,bdate)
        {
            ID = id;
            Department = dept;
            BasicSalary = bSalary;
            this.WorkingDays = daysWorked;
        }

        public int ID { get; set; }
        public string Department {  get; set; }
        public float BasicSalary { get; set; }
        public int WorkingDays { get; set; }

        public virtual float CalculateSalary()
        {
            float salary = BasicSalary + (100 * WorkingDays);
            return salary;
        }

        public override string ToString()
        {
            return base.ToString() + this.ID + " " +this.Department + " " + this.BasicSalary + " " + this.WorkingDays;
        }
    }
}
