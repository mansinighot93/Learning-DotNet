using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    //User Defined Structure
    public struct Point
    {
        public int x;
        public int y;
    }
    //Deterministic Finalization
    public class Person:IDisposable
    {
        //Refernces to inherits
        public Person() {
            this.FirstName = "";
            this.LastName = "";
            this.BirthDate = DateTime.Now;
        }
        public Person(string fName, string lName, DateTime bDate)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.BirthDate = bDate;
        }

        protected string FirstName {  get; set; }
        protected string LastName { get; set; }
        protected DateTime BirthDate { get; set; }
        public override string ToString() {
            return FirstName + " " + LastName + " " + BirthDate;
        }
        public void Dispose()
        {
            //Deinitializing system resources before object get destroyed
            //Releasing system resources which where used
            //database connection
            //multiple threads
            //files
            GC.SuppressFinalize(this);
        }

        ~Person()
        {
            //Deinitializing system resources before object get destroyed
            //Releasing system resources which where used
            //database connection
            //multiple threads
            //files
        }
    }
}
