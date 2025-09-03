using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Ticket_Handling
{
    // This class represents the Admin Dashboard form
    public partial class Admin_Dashboard : Form
    {
        // Store admin's full name and ID
        private string fullName;
        private int adminId;

        // Constructor receives admin's name and ID
        public Admin_Dashboard(string name, int id)
        {
            InitializeComponent(); // Initialize UI components
            fullName = name;       // Save admin's name
            adminId = id;          // Save admin's ID
        }

        // Event handler for "Manage Events" button
        private void button1_Click(object sender, EventArgs e)
        {
            // Open the Event Manager form
            Event_Manager eventManager = new Event_Manager();
            eventManager.Show();
        }

        // Event handler for an unused button (currently does nothing)
        private void button2_Click(object sender, EventArgs e)
        {
        }

        // Event handler for "Manage Attendees" button
        private void btnManageattendees_Click(object sender, EventArgs e)
        {
            // Open the View Attendee form
            View_Attendee viewAttendee = new View_Attendee();
            viewAttendee.Show();
        }

        // Event handler for "View Sales" button
        private void button1_Click_1(object sender, EventArgs e)
        {
            // Open the View Sales form
            View_Sales salesForm = new View_Sales();
            salesForm.Show();
        }

        // Event handler for form load (currently does nothing)
        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
        }

        private void btnViewRatings_Click(object sender, EventArgs e)
        {
            AdminFeedbackForm form = new AdminFeedbackForm();
            form.Show(); // or ShowDialog() if you want modal

        }
    }
}