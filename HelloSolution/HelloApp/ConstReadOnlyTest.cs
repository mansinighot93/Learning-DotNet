using System;
using System.Collections.Generic;
using HR;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HelloApp
{
    enum Weekdays { Mon,Tue,Wed,Thu,Fri,Sat,Sun};
    enum Months { Jan,Feb,Mar,Apr,May,Jun,July,Aug,Sep,Oct,Nov,Dec};
    class MathEngine
    {
        public const int Count = 56;//at the time of declration you have to initialize
        public readonly double PI;//you can declare but no need to initialize here
        public MathEngine(int num1,int num2)
        {
            PI = 3.14;
        }
        public MathEngine()
        {
            PI = 3.14;//Initialize only once
        }
        public int Add(int op1,int op2)
        {
            return op1 + op2;
        }
    }
    class ConstReadOnlyTest
    {
        static float area;
        static float circum;
        static void Swap(ref int n1,ref int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;
        }
        static void Calculate(float radius,out float area,out float circum)
        {
            area = 3.14f * radius * radius;
            circum = 2 * 3.14f * radius;
        }
        static void ViewNames(params string[] names)
        {
            //Console.WriteLine("Names: {0},{1},{2} ", names[0], names[1], names[2]);
            foreach (string i in names)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            Weekdays day = Weekdays.Mon;
            Months months = Months.Jun;
            Console.WriteLine(day + " " + months);

            int[] schoolMarks;//Declare
            int[] marks = new int[9];//Allocate
            int[] enggMarks = {1,2,3,4,5,6,7};//Initalize
            int[] decMarks = new int[] {1,2,3,4,6,7};
            string[] name = new string[] { "Manasi","Ajinkya"};

            foreach (int i in enggMarks)
            {
                Console.WriteLine(i);
            }
            foreach (string i in name)
            {
                Console.WriteLine(i);
            }

            List<String> list = new List<String>();//Generic list
            list.Add("Ajinkya");
            list.Add("Manasi");
            foreach (string i in list)
            {
                Console.WriteLine(i);
            }
            List<Person> people = new List<Person>();
            people.Add(new Person("Manasi", "Nighot", new DateTime(2003, 09, 21)));
            foreach (Person prn in people)
            {
                Console.WriteLine(prn);
            }
            #region MultipleViewNames
            ViewNames("Mansi", "Ajinkya", "Rutuja");
            ViewNames("Mansi", "Ajinkya");
            ViewNames("Manasi");
            #endregion

            int mumbaiPopultion = 45000;
            int punePopulation = 3400;
            Swap(ref mumbaiPopultion,ref punePopulation);
            Console.WriteLine("Mumbai Population:{0},Pune Population:{1}", mumbaiPopultion, punePopulation);

            float radius = 4;
            Calculate(radius, out area, out circum);
            Console.WriteLine("Area:{0},Circumference:{1}",area, circum);

            Console.ReadLine();
        }
    }
}
