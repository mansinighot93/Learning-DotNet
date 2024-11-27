using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Membership;

namespace WindowsFormsApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void OnLogin(object sender, EventArgs e)
        {
            //MessageBox.Show("Button is Click");
            string userName = this.textBox1.Text;
            string password = this.textBox2.Text;
            bool status;
            status = AccountManager.Login(userName, password);
            if (status)
            {
                this.Close();
                //MessageBox.Show("Welcome to Windows Form Application");
            }
            else
            {
                MessageBox.Show("Invalid User,Please Try Again.!");
            }
        }
        
        private void OnCancle(object sender, EventArgs e)
        {
            this.Close();
        }
        /*
        private void OnFileExit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnOpenFile(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
        }

        private void OnFileSaveAs(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.ShowDialog();
        }*/
    }
}
