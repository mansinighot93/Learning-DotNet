﻿using HR;
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

            Console.ReadLine();
        }
    }
}
