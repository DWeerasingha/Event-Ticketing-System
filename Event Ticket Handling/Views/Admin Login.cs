using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Event_Ticket_Handling.models;

namespace Event_Ticket_Handling
{
    // This class represents the admin login form
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent(); // Initialize all UI components
        }

        // Event handler for the Login button
        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            // Create a new Admin object and set username and password from textboxes
            Admin admin = new Admin
            {
                Username = txtUsername.Text.Trim(), // Remove extra spaces from username
                Password = txtPassword.Text.Trim()  // Remove extra spaces from password
            };

            // Check if login credentials are valid
            if (admin.Login())
            {
                // If login succeeds, hide the login form
                this.Hide();

                // Open the admin dashboard and pass username and user ID
                Admin_Dashboard dashboard = new Admin_Dashboard(admin.Username, admin.UserID);
                dashboard.Show();
            }
            else
            {
                // Show an error message if login fails
                MessageBox.Show("Invalid admin credentials.");
            }
        }

        // Event handler for form load (currently does nothing)
        private void Admin_Login_Load(object sender, EventArgs e)
        {
        }

        // Event handler for username textbox change (not used)
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
        }

        // Event handler for password textbox change (not used)
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }
    }
}