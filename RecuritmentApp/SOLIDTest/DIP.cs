using System;

namespace  DIP
{
    public interface IAccount
    {
        void Login();
        void Register();
    }

    public class Admin : IAccount
    {
        public void Login()
        {
            Console.WriteLine("Validate Admin");
        }
        public void Register()
        {
            Console.WriteLine("Register Admin");
        }
    }
 
    public class User : IAccount
    {
        public void Login()
        {
            Console.WriteLine("Validate User");
        }
        public void Register()
        {
            Console.WriteLine("Register User");
        }
    }

    public class AccountsController
    {
        IAccount account;
        public AccountsController(IAccount automobile)
        {
            this.account = automobile; 
        } 
        public void Login()
        {
            Console.WriteLine("Before Login Operation");
            Console.WriteLine("Extract InComming Request");
            account.Login();
            Console.WriteLine("Generate and Send Response");
        }  
        public void Register()
        {
            Console.WriteLine("Before Register Operation");
            Console.WriteLine("Extract InComming Request");
            account.Register();
            Console.WriteLine("Generate and Send Response");            
        }
    }
 
   /*  class Program
    {
        static void Main(string[] args)
        {
            IAccount AdminActor = new Admin();
            //IAccount userActor = new User();
            AccountsController controller = new AccountsController(AdminActor);
            controller.Login();
            Console.WriteLine( "*************************************");
            controller.Register();
            Console.Read();
        }
    } */
}