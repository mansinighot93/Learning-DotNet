using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    public class Program
    {
        static void Main(string[] args) //String array is represent command line argument
        {
            Console.WriteLine("Hello World ! " + args[0]);
            Console.WriteLine("Welcome To DotNet Programming ...");
            int count = 45;
            count = count++;
            if(count <= 300)
            {
                while(count < 299)
                {
                    Console.WriteLine("Count {0} ",count);
                    count++;
                }
            }
            Console.WriteLine("Please Enter Your Name :");
            string name = Console.ReadLine();
            Console.WriteLine("Good Morning {0} ",name);
            Console.ReadLine();
        }
    }
}
