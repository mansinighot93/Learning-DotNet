using HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    //Values Types: Values are stored on stack
    //Refernce Type: They are always stored on heap.
    //Heap is used for dynamic memory allocation for objects in .NET
    //Heap is managed by Garbage Collector
    //Garbage Collector takes care Automatic Memory Management
    //Abstract class enforce overriding
    public abstract class Shape
    {
        //Minimum one method has to be abstract
        abstract public void Draw();
        public string Color { get; set; }
        public string Width { get; set; }
        public void Display()
        {
            Console.WriteLine("Shape is getting displayed");
        }
    }
    public class Line : Shape
    {
        //Member Variables
        public Point StartPoint;
        public Point EndPoint;
        public override void Draw()
        {
            Console.WriteLine("Line is drawn..");
            Console.WriteLine("First Point {0},{1}",StartPoint.x,StartPoint.y);
            Console.WriteLine("Second Point {0},{1}", EndPoint.x, EndPoint.y);
            Console.WriteLine("Color = {0}", Color);
            Console.WriteLine("Width = {0}", Width);
        }
    }
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
    //Class Type:
    //Concrete class :classfrom who can create object it is a class from whom instance of class
    //Abstract Class:will be there but cannot create object of that class
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
            Console.WriteLine("Demo For Interface");
            IPrintable outputDevice = null;
            outputDevice = new Printer();
            //Late Binding:Function is resolve at the runtime
            //Early Binding:Function is resolve at the Complile time,Function Overloading static polymorphism which you call i.e function overloading
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
            Console.WriteLine("Demo for Abstract Class");
            Shape theShape = new Line();
            //Type Casting using keyword is used 'as'
            Line l = theShape as Line;
            l.StartPoint = new Point();
            l.StartPoint.x = 56;
            l.StartPoint.y = 34;
            l.EndPoint = new Point();
            l.EndPoint.x = 78;
            l.EndPoint.y = 56;

            theShape.Color = "Black";
            theShape.Width = "23";
            theShape.Draw();

            Console.WriteLine("Welcome to C#");
            Console.ReadLine();
        }
    }
}
