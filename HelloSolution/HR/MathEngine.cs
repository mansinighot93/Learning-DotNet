using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryApp
{
    static public class MathEngine
    {
        public static int Addition(int op1, int op2)
        {
            return op1 + op2;
        }
        public static int Substraction(int op1, int op2)
        {
            return op1 - op2;
        }
        public static int Multiplication(int op1, int op2)
        {
            return op1 * op2;
        }
        public static int division(int op1, int op2)
        {
            return op1 / op2;
        }
    }
}
