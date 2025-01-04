using System;
using System.Data;
using Mysql.Data.MySqlClient;
using Mysql.Data
using Syetem.Collections.Generic;

namespace Membership
{
    public static class SecurityManager
    {
        public static string conString=@"server=localhost;user=root;database=CRM;password='root'";
        public static List<Users> GetAll()
        {
            List<Users> allUsers = new List<Users>();
            MySqlConnection con = new MySqlConnection(conString);
            string query = "SELECT * FROM Users";

            MySqlCommand cmd= new MySqlCommand(query,con);
            try{
                con.open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    int id = int.Parse(reader["Id"].ToString());
                    string username = reader["UserName"].ToString();
                    string password = reader["Password"].ToString();

                    Users theUser = new Users{
                        Id=id,
                        UserName=username,
                        Password=password
                    };
                    allUsers.Add(theUser);
                }
                reader.Close();
            }
            catch(MySqlException exp){
                string message=exp.Message;
            }
            finally{
                con.close();
            }
            return allUsers;
        }

        public static bool Validate(string username,string password)
        {
            bool status = false;
            MySqlConnection con = new MySqlConnection(conString);
            string query = "SELECT * FROM Users WHERE username'" +username+ "'AND password='"+password+"'";
            MySqlCommand cmd = new MySqlCommand(con,query);

            try{
                con.Open();
                MySqlDataReader reader=cmd.ExecuteReader();

                if(reader.Read()){
                    status=true;
                }
                reader.Close();
            }
            catch(MySqlException exp){
                string message=exp.Message;
            }
            return status;
        }

        public static bool Register(Users users)
        {
            bool status = false;
            MySqlConnection con = new MySqlConnection(conString);
            string query = "INSERT INTO Users(id,username,password) VALUES(@Id,@UserName,@Password)";

            MySqlCommand cmd = new MySqlCommand(query,con);
            cmd.Parameters.Add(new MySqlParameter("@Id",users.Id));
            cmd.Parameters.Add(new MySqlParameter("@UserName",users.UserName));
            cmd.Parameters.Add(new MySqlParameter("@Password",users.Password));

            try{
                con.Open();
                cmd.ExcecuteNonQuery();
                status=true;
            }
            catch(MySqlException exp){
                string message=exp.Message;
            }
            return status;
        }
    }
}