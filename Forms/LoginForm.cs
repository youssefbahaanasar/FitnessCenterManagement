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
            errorProvider1.Clear();

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            bool valid = true;

            if (string.IsNullOrWhiteSpace(username))
            {
                errorProvider1.SetError(txtUsername, "Username is required");

                valid = false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                errorProvider1.SetError(
                    txtPassword, "Password is required");

                valid = false;
            }

            if (!valid)
                return;

            try
            {
                btnLogin.Enabled = false;
                btnLogin.Text = "Signing in...";

                var user = await _authService.LoginAsync(
                    username, password
                );

                if (user == null)
                {
                    MessageBox.Show(
                        "Invalid credentials or inactive account.",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                MessageBox.Show(
                    $"Welcome, {user.Username} ({user.Role})",
                    "Login Successful"
                );

                // Next step: open MainForm and pass user.Role
            }
            catch (SqlException)
            {
                MessageBox.Show(
                    "Unable to connect to the database.",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "An unexpected error occurred.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                btnLogin.Enabled = true;
                btnLogin.Text = "Login";
            }
        }


    }
}
