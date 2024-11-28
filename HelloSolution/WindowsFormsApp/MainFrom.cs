using System;
using Membership;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Catalog;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp
{
    public partial class MainFrom : Form
    {
        //List to hold all product collection as inventory
        private List<Product> allProducts = new List<Product>();
        public MainFrom()
        {
            InitializeComponent();//Code is wriiten in seperate designer.cs file
            LoginForm frm = new LoginForm();
            frm.ShowDialog();
        }
        //Event Handler
        //Developer should focus more on handling events with the help of event handler
        
        private void OnFileExit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnFileOpen(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
           if( dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = dlg.FileName;//get the name of file selected
                FileStream strem = new FileStream(fileName, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                this.allProducts = (List<Product>)bf.Deserialize(strem);
                strem.Close();
            }
            Display();
        }

        private void OnFileSaveAs(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = dlg.FileName;//get the name of file selected
                FileStream strem = new FileStream(fileName, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(strem, allProducts);
                strem.Close();
            }
        }

        private void OnToolLogin(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.ShowDialog();
        }

        private void OnInsert(object sender, EventArgs e)
        {
            //Get data from controls and store to variables
            int id = int.Parse(this.textBox1.Text);
            string title = this.textBox2.Text;
            string description = this.textBox3.Text;
            float unitprice = float.Parse(this.textBox4.Text);  
            int quantity = int.Parse(this.textBox5.Text);

            //create instance of product based on data recived
            Product theProduct = new Product
            {
                id = id,
                Title = title,
                Description = description,
                UnitPrice = unitprice,
                Qunatity = quantity
            };
            //add product data into list
            this.allProducts.Add(theProduct);
            //Bind list to dataProductGridView
            this.dataProductGridView.DataSource = null;
            this.dataProductGridView.DataSource = theProduct;
        }
        private int current = 0;

        private void OnFirst(object sender, EventArgs e)
        {
            this.current = 0;
            Display();
        }

        private void OnPrevious(object sender, EventArgs e)
        {
            if(this.current != 0)
            this.current = current - 1;
            Display();
        }

        private void OnNext(object sender, EventArgs e)
        {
            if(this.current != allProducts.Count)
            this.current = current + 1;
            Display();
        }

        private void OnLast(object sender, EventArgs e)
        {
            this.current = allProducts.Count - 1;
            Display();
        }
        private void Display()
        {
            Product theproduct = allProducts[current];
            this.textBox1.Text = theproduct.id.ToString();
            this.textBox2.Text = theproduct.Title.ToString();
            this.textBox3.Text = theproduct.Description.ToString();
            this.textBox4.Text = theproduct.UnitPrice.ToString();
            this.textBox5.Text = theproduct.Qunatity.ToString();
        }
    }
}
