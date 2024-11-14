using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    //Proto type :used to define contract,used to define specification,used to define guidlines
    //is used to enforce rules while building concrete class
    //Printing is a skill,a capability
    //class is implemented in one or more interface 
    //how many methods in declare interface have to all menthods implemented in class
    interface IPrintable
    {
        void Print();
        void Start();
        void Stop();
    }
    interface IScannable
    {
        void Scan();
    }
    //Proto type is implemented by concrete class
    //Class Type:Concrete and Abstract Class
    //Interface is implemeneted an multiple classes
    //Create n no.of interface
    class Printer : IPrintable, IScannable // Multiple interafce inheritance
    {
        void IPrintable.Print()
        {
            Console.WriteLine("Printing Data");
        }
        void IPrintable.Start()
        {
            Console.WriteLine("Start Method is invoked in Printing Data");
        }
        void IPrintable.Stop()
        {
            Console.WriteLine("Stop Method is invoked in Printing Data");

        }
        void IScannable.Scan()
        {
            Console.WriteLine("Scanning Printing Data");
        }
    }
    class ThreeDPrinter : IPrintable, IScannable
    {
        void IPrintable.Print()
        {
            Console.WriteLine("Printing 3D Data");
        }
        void IPrintable.Start()
        {
            Console.WriteLine("Start Method is invoked in 3D Printing Data");
        }
        void IPrintable.Stop()
        {
            Console.WriteLine("Stop Method is invoked in 3D Printing Data");

        }
        void IScannable.Scan()
        {
            Console.WriteLine("Scanning 3D Printing Data");
        }


    }
    class LanguageTest
    {
        static void Main(string[] args)
        {
            //value types
            int result = 12;
            float price = 24;
            bool status = false;
            double score = 4300;

            //Reference types: Class,inetrface,delegate,event
            //Values pointed by refernces type are always store on Heap
            //Heap is managed by Garbage Collector
            //Interface are always used polymorphic behaviour and lossely couple architecuture
           // Printer laserPrinter = new Printer();
            IPrintable outputDevice = null;
            outputDevice = new Printer();
            //Late Binding:
            //Early Binding:Function Overloading static polymorphism which you call i.e function overloading
            //When interface is used always is it going to consider late Binding?->yes
            outputDevice.Print();
            outputDevice.Start();
            outputDevice.Stop();

            //ThreeDPrinter jobPrinter = new ThreeDPrinter();
            outputDevice = new ThreeDPrinter();
            
            outputDevice.Print();
            outputDevice.Start();
            outputDevice.Stop();

            LanguageTest test = new LanguageTest();
            Console.WriteLine("Welcome to C#");
            Console.ReadLine();
        }
    }
}
