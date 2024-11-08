// See https://aka.ms/new-console-template for more information
using FirstConsoleApp;

int count = 100;
count++;
bool status =false ;
string company = "Transflower";
DateTime dateTime = DateTime.Now;
Person person = new Person();
Person person1 = new Person("Anaya","Nighot",23);
Employee employee = new Employee("Manasi","nighot",22,1,20.0,23,30.00);

Console.WriteLine(company);
Console.WriteLine(status);
Console.WriteLine(count);
Console.WriteLine(dateTime);
Console.WriteLine("Hello, World!\n");

person.show();
person1.show();
employee.show();
