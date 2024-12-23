using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Catalog;
using static System.Net.Mime.MediaTypeNames;
namespace Catlog
{
    public static class PrdocutDBManager
    {

        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Learning C#\Learning-DotNet\HelloSolution\HelloApp\Ecommerce.mdf"";Integrated Security=True";
        //CRUD Operation
        //Read
        public static bool GetProductByID(int productId)
        {
            //Logic for Deletion
            try
            {
                IDbConnection con = new SqlConnection();
                con.ConnectionString = connectionString;
                IDbCommand cmd = new SqlCommand();
                cmd.Connection = con;
                string query = "SELECT * FROM flowers WHERE productID=@id";
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@id", productId));
                con.Open();
                IDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int id = int.Parse(reader["productId"].ToString());
                    string title = reader["Title"].ToString();
                    string description = reader["Description"].ToString();
                    float unitPrice = float.Parse(reader["UnitPrice"].ToString());
                    int quantity = int.Parse(reader["Quantity"].ToString());
                    string image = reader["ImageUrl"].ToString();
                    Product theProduct = new Product
                    {
                        Id = id,
                        Title = title,
                        Description = description,
                        UnitPrice = unitPrice,
                        Quantity = quantity,
                        ImageUrl = image
                    };
                }
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            catch (SqlException exp)
            {
                string message = exp.Message;
            }
            return theProduct;
        }
        public static IEnumerable<Product> GetAllProducts()
        {
            //Invoke backend data into .NET application 
            //Needed database connectivity
            //You need to use:
            //1.Ado.NET Object Model(JDBC) (Activec Data Object or
            //2. Entity Framework (Hibernet)

            List<Product> allProducts = new List<Product>();
            IDbConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
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
                    int id = int.Parse(reader["Id"].ToString());
                    string title = reader["Title"].ToString();
                    string description = reader["Description"].ToString();
                    float unitPrice = float.Parse(reader["UnitPrice"].ToString());
                    int quantity = int.Parse(reader["Quantity"].ToString());
                    string image = reader["ImageUrl"].ToString();

                    Product theProduct = new Product
                    {
                        Id = id,
                        Title = title,
                        Description = description,
                        UnitPrice = unitPrice,
                        Quantity = quantity,
                        ImageUrl = image
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
            con.ConnectionString = connectionString;
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
                    int id = int.Parse(dataRow["Id"].ToString());
                    string title = dataRow["Title"].ToString();
                    string description = dataRow["Description"].ToString();
                    float unitPrice = float.Parse(dataRow["UnitPrice"].ToString());
                    int quantity = int.Parse(dataRow["Quantity"].ToString());
                    string image = dataRow["ImageUrl"].ToString();

                    allProducts.Add(new Product()
                    {
                        Id = id,
                        Title = title,
                        Description = description,
                        UnitPrice = unitPrice,
                        Quantity = quantity,
                        ImageUrl = image
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
            //using connected data access mode
            try
            {
                IDbConnection con = new SqlConnection();
                con.ConnectionString = connectionString;
                IDbCommand cmd = new SqlCommand();
                cmd.Connection = con;
                string query = "INSERT INTO flowers(ProductID,title,description,price,quantity)" +
                               "VALUES(@id,@Title,@Description,@Price,@Quantity)";
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@Id", theProduct.Id));
                cmd.Parameters.Add(new SqlParameter("@Title", theProduct.Title));
                cmd.Parameters.Add(new SqlParameter("@Description", theProduct.Description));
                cmd.Parameters.Add(new SqlParameter("@Image", theProduct.ImageUrl));
                cmd.Parameters.Add(new SqlParameter("@UnitPrice", theProduct.UnitPrice));
                cmd.Parameters.Add(new SqlParameter("@Quantity", theProduct.Quantity));
                con.Open();
                cmd.ExecuteNonQuery();
                status = true;
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            catch (SqlException exp)
            {
                string message = exp.Message;
            }
            return status;
        }

        //Update
        public static bool Update(Product theProduct)
        {
            //Logic for Updation
            bool status = false;
            try
            {
                IDbConnection con = new SqlConnection();
                con.ConnectionString = connectionString;
                string query = "UPDATE flowers SET title=@Title,description=@Description,price=@Price,quantity=@Quantity" +
                    "WHERE productID=@id";
                IDbCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@Id", theProduct.Id));
                cmd.Parameters.Add(new SqlParameter("@Title", theProduct.Title));
                cmd.Parameters.Add(new SqlParameter("@Description", theProduct.Description));
                cmd.Parameters.Add(new SqlParameter("@Image", theProduct.ImageUrl));
                cmd.Parameters.Add(new SqlParameter("@UnitPrice", theProduct.UnitPrice));
                cmd.Parameters.Add(new SqlParameter("@Quantity", theProduct.Quantity));
                con.Open();
                cmd.ExecuteNonQuery();
                status = true;
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            catch (SqlException exp)
            {
                string message = exp.Message;
            }
            return status;
        }

        //Delete
        public static bool Delete(int productID)
        {
            //Logic for Deletion
            bool status = false;
            try
            {
                IDbConnection con = new SqlConnection();
                con.ConnectionString = connectionString;
                IDbCommand cmd = new SqlCommand();
                cmd.Connection = con;
                string query = "DELETE FROM flowers WHERE productID=@id";
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@id", productID));
                con.Open();
                cmd.ExecuteNonQuery();
                status = true;
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            catch (SqlException exp)
            {
                string message = exp.Message;
            }
            return status;
        }
    }
}
