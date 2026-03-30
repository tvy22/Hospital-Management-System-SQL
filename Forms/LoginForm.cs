using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error");
                return;
            }

<<<<<<< HEAD
            if (user == "admin" && pass == "123")
=======
            if(user == "admin" && pass == "123")
>>>>>>> 47ee31b4a9dd0081bc60e20e0c10b5d78def2677
            {
                this.Hide();
                MainDashboard main = new MainDashboard();
                main.Show();
            }
            else
            {
                MessageBox.Show("Invalid username and password.", "Login Failed");
                txtUser.Focus();
            }
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
<<<<<<< HEAD
            if (e.KeyCode == Keys.Escape)
=======
            if(e.KeyCode == Keys.Escape)
>>>>>>> 47ee31b4a9dd0081bc60e20e0c10b5d78def2677
            {
                Application.Exit();
            }
        }
    }
}