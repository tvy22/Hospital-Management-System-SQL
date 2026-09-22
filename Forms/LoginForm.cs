using Hospital_Management_System_SQL.Interfaces;
using Hospital_Management_System_SQL.Logic;
using Hospital_Management_System_SQL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System_SQL.Forms
{
    public partial class LoginForm : Form
    {
        private readonly IStaffRepository _staffRepository;
        public LoginForm()
        {
            InitializeComponent();
            _staffRepository = new StaffRepository();
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

            Staff loggedInStaff = _staffRepository.Login(user, pass);

            if (loggedInStaff != null)
            {
                this.Hide();
                MainDashboard main = new MainDashboard();
                main.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed");
                txtUser.Focus();
            }
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            if(e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }
    }
}