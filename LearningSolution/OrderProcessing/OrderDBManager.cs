using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace OrderProcessing
{
    // Connected Data Access Object Model
    
    public  static class OrderDBManager
    {
       
        public static string conString = @"server=localhost;user=root;database=learningapp;password='password'";
        public static List<Orders> GetAll() 
        {
            List<Orders> customers = new List<Orders>();
            IDbConnection con = new MySqlConnection(conString);
            string query = "SELECT * FROM Customers";
            IDbCommand cmd = new MySqlCommand(query, con as MySqlConnection);
            try
            {
                con.Open(); 
                IDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["Id"].ToString());
                    DateTime date = DateTime.Parse(reader["OrderDate"].ToString());
                    string status = reader["Status"].ToString();
                    double amount = double.Parse(reader["TotalAmount"].ToString());

                    customers.Add(new Orders()
                    {
                        Id = id,
                        OrderDate = date,
                        Status = status,
                        TotalAmount = amount
                    });
                }
                reader.Close();
            }
            catch (MySqlException exp)
            {
                string message = exp.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                     con.Close();
                }
            }
            return customers;
        }

        public static Orders GetById(int orderId){
            Orders theOrder = null;
            try{
                IDbConnection con = new MySqlConnection(conString);
                if(con.State == ConnectionState.Closed)
                    con.Open();
                string query = "SELECT * FROM Orders WHERE Id=@orderId";
                IDbCommand cmd =new MySqlCommand(query,con as MySqlConnection);
                cmd.Parameters.Add(new MySqlParameter("@orderId",orderId));
                IDataReader reader = cmd.ExecuteReader();

                if(reader.Read()){
                    int id = int.Parse(reader["Id"].ToString());
                    DateTime date = DateTime.Parse(reader["OrderDate"].ToString());
                    string status = reader["Status"].ToString();
                    double amount = double.Parse(reader["TotalAmount"].ToString());

                    theOrder = new Orders(){
                        Id = id,
                        OrderDate = date,
                        Status = status,
                        TotalAmount = amount
                    };

                    reader.Close();
                    if(con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            catch(MySqlException exp){
                string message = exp.Message;
            }
            return theOrder;
        }

        public static bool Delete(int orderId){
            bool status = false;
            try{
                MySqlConnection con = new MySqlConnection(conString);
                if(con.State == ConnectionState.Closed)
                    con.Open();
                string query = "DELETE FROM Orders WHERE Id=@orderId";
                MySqlCommand cmd = new MySqlCommand(query,con);
                cmd.Parameters.Add(new MySqlParameter("@orderId",orderId));
                cmd.ExecuteNonQuery();
                if(con.State == ConnectionState.Open)
                    con.Close();
                status = true;
            }
            catch(MySqlException exp){
                string message = exp.Message;
            }
            return status;
        }

        public static bool Update(Orders orders){
            bool status = false;
            try{
                MySqlConnection con = new MySqlConnection(conString);
                if(con.State == ConnectionState.Closed)
                    con.Open();
                string query = "UPDATE Orders SET OrderDate=@OrderDate,Status=@Status,TotalAmount=@TotalAmount" + "WHERE Id=@Id";
                MySqlCommand cmd = new MySqlCommand(query,con);
                cmd.Parameters.Add(new MySqlParameter("@Id",orders.Id));
                cmd.Parameters.Add(new MySqlParameter("@OrderDate",orders.OrderDate));
                cmd.Parameters.Add(new MySqlParameter("@Status",orders.Status));
                cmd.Parameters.Add(new MySqlParameter("@TotalAmount",orders.TotalAmount));
                cmd.ExecuteNonQuery();
                if(con.State == ConnectionState.Open)
                    con.Close();
                status=true;
            }
            catch(MySqlException exp){
                string message=exp.Message;
            }
            return status;
        }

        public static bool Insert(Orders orders){
            bool status = false;
            try{
                MySqlConnection con = new MySqlConnection(conString);
                if(con.State == ConnectionState.Closed)
                    con.Open();
                string query = "INSERT INTO Orders(Id,OrderDate,Status,TotalAmount) VALUES(@Id,@OrderDate,@Status,@TotalAmount)";
                MySqlCommand cmd = new MySqlCommand(query,con);
                cmd.Parameters.Add(new MySqlParameter("@Id",orders.Id));
                cmd.Parameters.Add(new MySqlParameter("@OrderDate",orders.OrderDate));
                cmd.Parameters.Add(new MySqlParameter("@Status",orders.Status));
                cmd.Parameters.Add(new MySqlParameter("@TotalAmount",orders.TotalAmount));

                cmd.ExecuteNonQuery();
                if(con.State == ConnectionState.Open)
                    con.Close();
                status = true;
            }
            catch(MySqlException exp){
                string message = exp.Message;
            }
            return status;
        }
    }
}
