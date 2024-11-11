using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    public class Program
    {
        //Static Function
        static int Addition(int num1,int num2)
        {
            return num1 + num2;
        }
        static int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }
        static int Substraction(int num1, int num2)
        {
            return num1 - num2;
        }
        static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
        //Access Specifier: Public ,Private,Protected.Internal
        //Member Function
        public void Display()
        {
            Console.WriteLine("Welcome To Dotnet Programming language");
        }
        static void Main(string[] args) //String array is represent command line argument
        {
            for (int i = 0; i < args.Length; i++) {
                Console.WriteLine("Hello World ! " + args[i]);
            }
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

            //Calling Class
            Program program = new Program();
            program.Display();

            int add = Addition(1, 2);
            int mul = Multiplication(1, 2);
            int sub = Substraction(1, 2);
            int div = Divide(1, 2);
            Console.WriteLine(add + " " + mul + " " + sub + " " + div);

            Console.ReadLine();
        }
    }
}
