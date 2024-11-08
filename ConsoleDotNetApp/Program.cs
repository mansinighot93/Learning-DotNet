// See https://aka.ms/new-console-template for more information
using ConsoleDotNetApp;

int count = 100;
count++;
bool status =false ;
string company = "Transflower";
DateTime dateTime = DateTime.Now;
Person person = new Person();
Person person1 = new Person("Anaya","Nighot",23);
Employee employee = new Employee();
Employee2 emp = new Employee2("Manasi Nighot","manasi.nighot@gmail.com",9561128566);


Console.WriteLine(company);
Console.WriteLine(status);
Console.WriteLine(count);
Console.WriteLine(dateTime);
Console.WriteLine("Hello, World!\n");

person.show();
person1.show();
employee.show();
emp.show();
