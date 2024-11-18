using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryApp
{
    //.NET Framework provides lot of inbuilt class lirbraies to be consumed in application
    //Class library (.dll(dynamic link library)) are dependencies for application
    public class Complex
    {
        public int real;
        public int imag;
        public Complex(int r,int i) { 
            real = r;
            imag = i;
        }
        public static Complex operator+ (Complex c1,Complex c2 )
        {
            Complex temp = new Complex(23,24);
            temp.real = c1.real + c2.real;
            temp.imag = c1.imag + c2.imag;
            return temp;
        }
    }
}
