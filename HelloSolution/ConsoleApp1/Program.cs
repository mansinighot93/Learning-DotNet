using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int Add(int op1,int op2)
        {
            int result = op1 + op2;
            return result;
        }
        static int Subtract(int op1, int op2)
        {
            int result = op1 - op2;
            return result;
        }
        static int Multiply(int op1, int op2)
        {
            int result = op1 * op2;
            return result;
        }
        static void Main(string[] args)
        {
            int num1 = 34;
            int num2 = 56;
            int realResult = Add(num1, num2);
            Console.WriteLine("Result:{0}",realResult);
            Console.ReadLine();
        }
    }
}
