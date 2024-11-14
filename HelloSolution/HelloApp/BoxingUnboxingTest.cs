using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    class BoxingUnboxingTest
    {
        static void Main(string[] args)
        {
            //Value type
            int count = 45;

            //Refernce type:
            //Boxing is a technique where value type are transformed into refernce type
            //Value type is wrapped in refernce type
            Object o = count;
            Console.WriteLine(o);

            //Unboxing is a technique where refernce type is unwrapped and value type is recived
            int result = (int)o;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
