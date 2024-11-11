using System;
using Catalog;
using Membership;
using ShoppingCart;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    public class Program
    {
        //Getter,Setter Method
        private string programName;
        public void SetProgram(string name)
        {
            this.programName = name;
        }

        public string GetProgram()
        {
            return this.programName;
        } // Old Version In Write type of this code
         

        //Property Getter,Setter
        public string Name
        {
            get { return this.programName; }
            set { this.programName = value; }
        } //New Version In Write Type of this code but both syntax used in new version


        //Constructor OverLoading
        public Program() {
            this.programName = "DotNet Learning";
        }
        public Program(string name)
        {
            this.programName = name;
        }


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
            program.Name = "My best program"; //Set Property
            Console.WriteLine(program.Name); // Get Property

            int add = Addition(1, 2);
            int mul = Multiplication(1, 2);
            int sub = Substraction(1, 2);
            int div = Divide(1, 2);
            Console.WriteLine(add + " " + mul + " " + sub + " " + div);

            Product product1 = new Product(1,"Rose","Valentine Flower",4500,20);
            Console.WriteLine(product1);
            Product product2 = new Product(2, "Gerbera", "Weeding Flower", 450, 10);
            Console.WriteLine(product2);

            Console.ReadLine();
        }
    }
}
