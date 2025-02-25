
using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace CRM
{
    // Connected Data Access Object Model
    
    public  static class CustomerDBManager
    {
       
    public static string conString = @"server=localhost;user=root;database=onlineshopping;password='password'";
    public static List<Customers> GetAll() 
        {
            List<Customers> customers = new List<Customers>();
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
                    string name = reader["Name"].ToString();
                    string Email = reader["Email"].ToString();
                    int contactNumber = int.Parse(reader["ContactNumber"].ToString());
                    string location = reader["Location"].ToString();
                    int age = int.Parse(reader["Age"].ToString());

                    customers.Add(new Customers()
                    {
                        Id = id,
                        Name = name,
                        Email = Email,
                        ContactNumber = contactNumber,
                        Location = location,
                        Age = age
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

    public static Customers GetById(int customerId)
        {
            Customers theCustomer=null;
            try
            {
                
                MySqlConnection con = new MySqlConnection(conString);
                if (con.State == ConnectionState.Closed)
                 con.Open();

                //paramerized query
                string query = "SELECT * FROM customers WHERE Id=@CustomerId";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add(new MySqlParameter("@CustomerId", customerId));
               //Parameterized command handling*/
               
                 IDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["Id"].ToString());
                    string name = reader["Name"].ToString();
                    string Email = reader["Email"].ToString();
                    int contactNumber = int.Parse(reader["ContactNumber"].ToString());
                    string location = reader["Location"].ToString();
                    int age = int.Parse(reader["Age"].ToString());

     
                    theCustomer=new Customers()
                    {
                        Id = id,
                        Name = name,
                        Email = Email,
                        ContactNumber = contactNumber,
                        Location = location,
                        Age = age
                    };

                }
                reader.Close();
                if (con.State == ConnectionState.Open)
                con.Close();
            }
            catch (MySqlException ee) {
                string message = ee.Message;
            }
            return theCustomer;
        }

    public static bool Delete(int customerId)
        {
            bool status = false;
            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                if (con.State == ConnectionState.Closed)
                 con.Open();
                string query = "DELETE FROM Customers WHERE Id=@CustomerId";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add(new MySqlParameter("@CustomerId", customerId)); //Parameterized command handling
                cmd.ExecuteNonQuery();  // DML Operation
                if (con.State == ConnectionState.Open)
                con.Close();
                status = true;
            }
            catch (MySqlException ee) {
                string message = ee.Message;
            }
            return status;
        }  

    public static bool Update(Customers customer)
        {
            bool status = false;
            try
            {
              MySqlConnection con = new MySqlConnection(conString);
                {
                    if (con.State == ConnectionState.Closed)
                    con.Open();

                    string query = "UPDATE Customers SET Name=@Name , ContactNumber=@ContactNumber, " +
                        "Email=@Email, Location=@Location, Age=@Age " +
                        "WHERE Id=@Id";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.Add(new MySqlParameter("@Id", customer.Id));
                    cmd.Parameters.Add(new MySqlParameter("@Name", customer.Name));
                    cmd.Parameters.Add(new MySqlParameter("@ContactNumber", customer.ContactNumber));
                    cmd.Parameters.Add(new MySqlParameter("@Email", customer.Email));
                    cmd.Parameters.Add(new MySqlParameter("@Location", customer.Location));
                    cmd.Parameters.Add(new MySqlParameter("@Age", customer.Age));   

                    cmd.ExecuteNonQuery();  // DML Operation

                    if (con.State == ConnectionState.Open)
                        con.Close();
                    status = true;
                }
            }
            catch (MySqlException ex)
            {
                string message = ex.Message;
            }
            return status;
        }

    public static bool Insert(Customers customer)
        {
            bool status = false;
            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                {
                    if (con.State == ConnectionState.Closed)
                    con.Open();

                    string query = "INSERT INTO Customers (Id,Name, ContactNumber, Email, Location, Age) " +
                        "VALUES (@Id, @Name, @ContactNumber, @Email, @Location, @Age)";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.Add(new MySqlParameter("@Id", customer.Id));
                    cmd.Parameters.Add(new MySqlParameter("@Name", customer.Name));
                    cmd.Parameters.Add(new MySqlParameter("@ContactNumber", customer.ContactNumber));
                    cmd.Parameters.Add(new MySqlParameter("@Email", customer.Email));
                    cmd.Parameters.Add(new MySqlParameter("@Location", customer.Location));
                    cmd.Parameters.Add(new MySqlParameter("@Age", customer.Age));  

                    cmd.ExecuteNonQuery();// DML

                    if (con.State == ConnectionState.Open)
                        con.Close();
                    status = true;
                }
            }
            catch (MySqlException ex)
            {
                string message = ex.Message;
            }
            return status;
        }
    }
}