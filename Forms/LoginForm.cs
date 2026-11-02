using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitnessCenterManagement.Services;
using Microsoft.Data.SqlClient;
namespace FitnessCenterManagement.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private readonly AuthService _authService = new();

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Mock authentication logic (Replace with Database query)
            if (username == "admin" && password == "123")
            {
                OpenMainForm(UserRole.Admin, "Administrator");
            }
            else if (username == "reception" && password == "123")
            {
                OpenMainForm(UserRole.Receptionist, "Receptionist User");
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void OpenMainForm(UserRole role, string displayName)
        {
            MainForm main = new MainForm(role, displayName);
            this.Hide();
            main.ShowDialog();
            this.Close(); // Closes application when MainForm exits
        }

    }
}
