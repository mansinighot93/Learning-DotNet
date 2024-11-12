using HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    public class EmployeeTest
    {
        public static void Main(string[] args)
        {
            DateTime bdate = new DateTime(2003,09,21);
            Person person = new Person("Manasi","Nighot",bdate);
            Console.WriteLine(person);

            Employee employee = new SalesEmployee("Manasi","Nighot",bdate,2,"Teacher",25000,28,5000);
            float salary = employee.CalculateSalary();
            Console.WriteLine("Manasi Nighot : Salary : {0}",salary);
             
            Console.ReadLine();
        }
    }
}
