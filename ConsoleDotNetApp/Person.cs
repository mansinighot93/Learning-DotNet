using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDotNetApp
{
    //Abstraction
    public class Person
    {
            //Encapsulated
            private string firstname;
            private string lastname;
            private int age;

        public Person() {
            this.firstname = "Manasi";
            this.lastname = "Nighot";
            this.age = 22;
        }
        public Person(string firstname,string lastname,int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
        }

        public void show()
        {
            Console.WriteLine(this.firstname +" ,"+ this.lastname);
        }
    }
}
