﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    //Define Delegate
    public  delegate void Handler();
    //Delegate at like a function pointer
    //Delegate is a wrapper for the function pointer in C#
    //Delegate always match the signature of those function which would be call as a runtime
    //Delegate is a keyword declare delegate
    
    class DelegationText
    {
        public static void PayIncomeTax()
        {
            Console.WriteLine("15% income tax is deducted from your account");
        }
        public static void PayServiceTax()
        {
            Console.WriteLine("15% Service tax is deducted from your account");
        }
        public static void PayProffesionalTax()
        {
            Console.WriteLine("15% Proffesional tax is deducted from your account");
        }
        static void Main(string[] args)
        {
            //Early Binding
            PayIncomeTax();
            PayServiceTax();
            PayProffesionalTax();

            //Late Binding
            Handler operation1 = null;
            operation1 = new Handler(PayIncomeTax);
            //operation1();

            Handler operation2 = null;
            operation2 = new Handler(PayServiceTax);
            //operation2();

            Handler operation3 = null;
            operation3 = new Handler(PayProffesionalTax);//Unicast Delegate
            //operation3();

            Handler masterOperation = null;
            masterOperation += operation1;//Multicast Delegate
            masterOperation += operation2;
            masterOperation += operation3;
            masterOperation();//One invokation

            Console.WriteLine("After Ungegistration");
            masterOperation -= operation1;//Remove operation1
            masterOperation();
            Console.ReadLine();
        }
    } 
}
