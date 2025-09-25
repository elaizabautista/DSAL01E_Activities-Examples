using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson3_Exercises
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            password_Txtbox.UseSystemPasswordChar = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            username_Txtbox.Focus();
        }

        private void login_Btn_Click(object sender, EventArgs e)
        {
            string username, password;
            username = "admin12345";
            password = "admin";
            
            if (username_Txtbox.Text == username && password_Txtbox.Text == password)
            {
                Login mainform = new Login();
                MessageBox.Show("Welcome!!!");
                mainform.Show();
                this.Hide();
            }
        }

        private void cancel_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
