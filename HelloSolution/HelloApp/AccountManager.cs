using CRM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membership
{
    public static class AccountManager
    {
        public static bool Login(string userName, string password)
        {
            bool status = false;
            if (userName == "manasi@123" || password == "pass@123") { 
                status = true;
            }
            return status;
        }
        public static bool Register(string LoginId, string name,string password,string email,string contactnumber,string location)
        {
            bool status = false;
            Customer theCustomer = new Customer();
            theCustomer.FullName = name;
            theCustomer.UserID = LoginId;
            theCustomer.Password = password;
            theCustomer.Email = email;
            theCustomer.ContactNumber = contactnumber;
            theCustomer.Location = location;

            //theCustomer = null;

            if(theCustomer != null)
            {
                status = true;
            }
            return status;
        }
        public static bool ChangePassword(string LoginId, string existingPassword,string newPassword)
        {
            bool status = false;

            return status;
        }
        public static bool ForgotPassword(string LoginId)
        {
            bool status = false;

            return status;
        }
    }
}
