﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Catalog;
namespace DAL
{
    public static class CatalogDBManager
    {
        //CRUD Operation
        //Read
        public static IEnumerable<Product> GetAllProducts()
        {
            //Invoke backend data into .NET application 
            //Needed database connectivity
            //You need to use:
            //1.Ado.NET Object Model(JDBC) (Activec Data Object or
            //2. Entity Framework (Hibernet)

            List<Product> allProducts = new List<Product>();
            IDbConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Learning C#\Learning-DotNet\HelloSolution\HelloApp\Ecommerce.mdf"";Integrated Security=True";
            //1.Connect to database
            //Qurey against database using SQL
            //get resultset from Query Processing
            //Create List of Products from resultset
            //return list of products
            IDbCommand cmd = new SqlCommand();
            string query = "SELECT * FROM flowers";
            cmd.Connection = con;
            cmd.CommandText = query;

            IDataReader reader = null;
            
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["ProductID"].ToString());
                    string title = reader["title"].ToString();
                    string description = reader["description"].ToString();
                    int price = int.Parse(reader["price"].ToString());
                    int quantity = int.Parse(reader["quantity"].ToString());
                    Product theProduct = new Product
                    {
                        id = id,
                        Title = title,
                        Description = description,
                        UnitPrice = price,
                        Qunatity = quantity
                    };
                    allProducts.Add(theProduct);
                }
                reader.Close();
            }
            catch (SqlException exp)
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
            return allProducts;
        }

       //Create
        public static bool Insert(Product theProduct)
        {
            //Logic for Insertion
            bool status = false;
            return status;
        }

        //Update
        public static bool Update(Product theProduct)
        {
            //Logic for Updation
            bool status = false;
            return status;
        }

        //Delete
        public static bool Delete(Product theProduct)
        {
            //Logic for Deletion
            bool status = false;
            return status;
        }
    }
}
