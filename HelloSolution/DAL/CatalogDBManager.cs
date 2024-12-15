using System;
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
                //using connected data access of ado.NET
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

        public static IEnumerable<Product> GetAllProductUsingDisconnected()
        {
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

            try
            {
                DataSet ds = new DataSet();
                //Empty DataSet
                SqlDataAdapter da = new SqlDataAdapter(cmd as SqlCommand);
                da.Fill(ds);
                //Data will be filled with results recived from database
                //Dataset is collection of DataTable object retirved
                //from database after fill method

                DataTable dt = ds.Tables[0];
                //DataTable is a collection of DataRow object

                foreach (DataRow dataRow in dt.Rows)
                {
                    int id = int.Parse(dataRow["ProductID"].ToString());
                    string title = dataRow["title"].ToString();
                    string description = dataRow["description"].ToString();
                    int price = int.Parse(dataRow["price"].ToString());
                    int quantity = int.Parse(dataRow["quantity"].ToString());

                    allProducts.Add(new Product()
                    {
                        id = id,
                        Title = title,
                        Description = description,
                        UnitPrice = price,
                        Qunatity = quantity
                    });
                }
            }
            catch (SqlException exp)
            {
                string message = exp.Message;
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
