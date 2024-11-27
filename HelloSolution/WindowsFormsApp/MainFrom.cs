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

namespace WindowsFormsApp
{
    public partial class MainFrom : Form
    {
        private List<Product> allProducts = new List<Product>();
        public MainFrom()
        {
            InitializeComponent();//Code is wriiten in seperate designer.cs file
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
            dlg.ShowDialog();
        }

        private void OnFileSaveAs(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.ShowDialog();  
        }

        private void OnToolLogin(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.ShowDialog();
        }

        private void OnInsert(object sender, EventArgs e)
        {
            int id = int.Parse(this.textBox1.Text);
            string title = this.textBox2.Text;
            string description = this.textBox3.Text;
            float unitprice = float.Parse(this.textBox4.Text);  
            int quantity = int.Parse(this.textBox5.Text);

            Product theProduct = new Product
            {
                id = id,
                Title = title,
                Description = description,
                UnitPrice = unitprice,
                Qunatity = quantity
            };
            this.allProducts.Add(theProduct);
        }
    }
}
