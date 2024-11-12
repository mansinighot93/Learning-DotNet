using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    public class SalesEmployee : Employee
    {
        public float Incentive { get; set; }
        public SalesEmployee(string fname,string lname,DateTime bdate,int id,string dept,float bSalary,int daysWorked,float incentive):base(fname,lname,bdate,id,dept,bSalary,daysWorked)
        {
            this.Incentive = incentive;
        }
        public override float CalculateSalary()
        {
            return base.CalculateSalary() + Incentive;
        }
        public override string ToString()
        {
            return base.ToString() + " " + Incentive;
        }
    }
}
