// See https://aka.ms/new-console-template for more information
using Banking;
using Maths;
Console.WriteLine("Hello, World!");

var p = new{
    FirstName = "Manasi",
    LastName = "nighot"
};
Console.WriteLine(p.FirstName + " " + p.LastName);

Account a1 = new Account(6000);
a1.Deposite(15000);
Console.WriteLine(a1.GetBalance());

Account a2 = new Account(60000);
a2.Deposite(15000);
Console.WriteLine(a2.GetBalance());

List<Account> accounts=new List<Account>();
accounts.Add(a1);
accounts.Add(a2);

foreach( Account theAccount in accounts){
    float result=theAccount.GetBalance();
    Console.WriteLine("Current Balance={0}",result);
}

Complex c1=new Complex(34,56);
Complex c2=new Complex(11,78);
Complex c3=c1 + c2;
