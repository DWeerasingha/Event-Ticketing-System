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
using System.Xml.Linq;
using Event_Ticket_Handling.models;


namespace Event_Ticket_Handling
{
    // This class represents the attendee login form
    public partial class Attendee_Login : Form
    {
        public Attendee_Login()
        {
            InitializeComponent(); // Initialize all UI components
        }

        // Event handler for the Registration button click
        private void btnRegistration_Click(object sender, EventArgs e)
        {
            // Open the attendee registration form
            Attendee_Registration attendee_Registration = new Attendee_Registration();
            attendee_Registration.Show();
        }

        // Event handler for the Login button click
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Create a new Attendee object and set email and password from textboxes
            Attendee attendee = new Attendee
            {
                Email = txtUseremail.Text.Trim(), // Remove extra spaces from email
                Password = txtPassword.Text.Trim() // Remove extra spaces from password
            };

            // Check if login credentials are valid
            if (attendee.Login())
            {
                // If login succeeds, hide this login form
                this.Hide();

                // Open the attendee dashboard and pass username and user ID
                AttendeeDashboard dashboard = new AttendeeDashboard(attendee.Username, attendee.UserID);
                dashboard.Show();
            }
            else
            {
                // Show an error message if login fails
                MessageBox.Show("Invalid email or password.");
            }
        }

        // Event handler for form load (currently does nothing)
        private void Attendee_Login_Load(object sender, EventArgs e)
        {
        }

        // Unused event handlers for textboxes, labels, and picture boxes
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void txtPassword_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
    }
}