using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public static class CustomerDBManager
    {
        public static string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Learning C#\Learning-DotNet\HelloSolution\HelloApp\Ecommerce.mdf"";Integrated Security=True";
        public static List<Customers> GetAll()
        {
            List<Customers> customers = new List<Customers>();
            IDbConnection con = new SqlConnection(conString);
            string query = "SELECT * FROM customers";
            IDbCommand cmd = new SqlCommand(query,con as SqlConnection);
            try
            {
                con.Open();
                IDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["Id"].ToString());
                    string name = reader["Name"].ToString();
                    string Email = reader["Email"].ToString();
                    string contactNumber = reader["ContactNumber"].ToString();

                    customers.Add(new Customers()
                    {
                        Id = id,
                        Name = name,
                        Email = Email,
                        ContactNumber = contactNumber
                    });
                }
                reader.Close();
            }
            catch(Exception exp)
            {
                string msg = exp.Message;
            }
            finally
            {
                if(con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return customers;
        } 
        public static Customers GetById(int customerId)
        {
            Customers theCustomer = null;
            try
            {
                SqlConnection con = new SqlConnection(conString);
                string query = "SELECT * FROM customers WHERE Id = @CustomerId";
                SqlCommand cmd = new SqlCommand(query, con as SqlConnection);
                cmd.Parameters.Add(new SqlParameter("@CustomerId", customerId));
                IDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["Id"].ToString());
                    string name = reader["Name"].ToString();
                    string Email = reader["Email"].ToString();
                    string contactNumber = reader["ContactNumber"].ToString();

                    theCustomer = new Customers()
                    {
                        Id = id,
                        Name = name,
                        Email = Email,
                        ContactNumber = contactNumber
                    };
                }
                reader.Close();
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            catch(Exception exp)
            {
                string msg = exp.Message;
            }
            return theCustomer;
        }
        public static bool Delete(int customerId)
        {
            bool status = false;
            try
            {
                SqlConnection con = new SqlConnection(conString);
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string query = "DELETE FROM customers WHERE Id=@CustomerId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("@CustomerId", customerId)); //Parameterized command handling
                cmd.ExecuteNonQuery();  // DML Operation
                if (con.State == ConnectionState.Open)
                    con.Close();
                status = true;
            }
            catch (SqlException exp)
            {
                string message = exp.Message;
            }
            return status;
        }
        public static bool Update(Customers customer)
        {
            bool status = false;
            try
            {
                SqlConnection con = new SqlConnection(conString);
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    string query = "UPDATE customer SET Name=@Name , Email=@Email, " +
                                    "ContactNumber=@ContactNumber " + "WHERE Id=@Id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@Id", customer.Id));
                    cmd.Parameters.Add(new SqlParameter("@Title", customer.Name));
                    cmd.Parameters.Add(new SqlParameter("@Description", customer.ContactNumber));
                    cmd.Parameters.Add(new SqlParameter("@Image", customer.Email));

                    cmd.ExecuteNonQuery();  // DML Operation
                    if (con.State == ConnectionState.Open)
                        con.Close();
                    status = true;
                }
            }
            catch (SqlException exp)
            {
                throw exp;
            }
            return status;
        }
        public static bool Insert(Customers customer)
        {
            bool status = false;
            try
            {
                SqlConnection con = new SqlConnection(conString);
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    string query = "INSERT INTO customers (Id,Name, Email, ContactNumber) " +
                                    "VALUES (@Id, @Name, @ContactNumber)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@Id", customer.Id));
                    cmd.Parameters.Add(new SqlParameter("@Name", customer.Name));
                    cmd.Parameters.Add(new SqlParameter("@ContactNumber", customer.ContactNumber));
                    cmd.Parameters.Add(new SqlParameter("@Email", customer.Email));
                    cmd.ExecuteNonQuery();// DML
                    if (con.State == ConnectionState.Open)
                        con.Close();
                    status = true;
                }
            }
            catch (SqlException exp)
            {
                string message = exp.Message;
                throw exp;
            }
            return status;
        }
    }
}
