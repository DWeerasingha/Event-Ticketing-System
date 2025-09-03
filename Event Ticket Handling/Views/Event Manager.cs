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
using Event_Ticket_Handling.Classes;
using Event_Ticket_Handling.models;
using Event_Ticket_Handling.Services;

namespace Event_Ticket_Handling
{
    // This class represents the Event Manager form
    public partial class Event_Manager : Form
    {
        private EventService eventService; // Service to handle event database operations

        // Constructor
        public Event_Manager()
        {
            InitializeComponent(); // Initialize UI components
            eventService = new EventService(); // Create instance of EventService
        }

        // Event handler for form load
        private void Event_Manager_Load(object sender, EventArgs e)
        {
            LoadEvents(); // Load all events into the grid when form opens
        }

        // Load events from database and display in DataGridView
        private void LoadEvents()
        {
            DataTable dt = eventService.GetAllEvents();
            dataGridViewEvents.DataSource = dt;
        }

        // Event handler for "Add Event" button
        private void btnAddevent_Click(object sender, EventArgs e)
        {
            Event ev = new Event
            {
                EventName = txtEventName.Text,
                Date = txtDate.Value.Date,
                Venue = txtVenue.Text,
                Description = txtDescription.Text
            };

            if (eventService.AddEvent(ev))
            {
                MessageBox.Show("Event added successfully!");
                LoadEvents(); // Refresh the DataGridView
            }
        }

        // Event handler for "Update Event" button
        private void btnUpdateevent_Click(object sender, EventArgs e)
        {
            Event ev = new Event
            {
                EventID = int.Parse(txtEventID.Text),
                EventName = txtEventName.Text,
                Date = txtDate.Value.Date,
                Venue = txtVenue.Text,
                Description = txtDescription.Text
            };

            if (eventService.UpdateEvent(ev))
            {
                MessageBox.Show("Event updated successfully!");
                LoadEvents(); // Refresh the DataGridView
            }
            else
            {
                MessageBox.Show("Update failed.");
            }
        }

        // Event handler for "Delete Event" button
        private void btnDeleteevent_Click(object sender, EventArgs e)
        {
            int eventId = int.Parse(txtEventID.Text);
            if (eventService.DeleteEvent(eventId))
            {
                MessageBox.Show("Event deleted successfully!");
                LoadEvents(); // Refresh the DataGridView
            }
            else
            {
                MessageBox.Show("Delete failed.");
            }
        }

        // Event handler for "Refresh" button
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadEvents(); // Reload all events
        }

        // Event handler for DataGridView cell click
        private void dataGridViewEvents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewEvents.Rows[e.RowIndex];

                // Fill the textboxes with the selected event's details
                txtEventID.Text = row.Cells["EventID"].Value.ToString();
                txtEventName.Text = row.Cells["EventName"].Value.ToString();
                txtDate.Value = Convert.ToDateTime(row.Cells["Date"].Value);
                txtVenue.Text = row.Cells["Venue"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();
            }
        }

        // Event handler for "Manage Tickets" button
        private void btnManagetickets_Click(object sender, EventArgs e)
        {
            if (dataGridViewEvents.CurrentRow != null)
            {
                int eventID = Convert.ToInt32(dataGridViewEvents.CurrentRow.Cells["EventID"].Value);
                string eventName = dataGridViewEvents.CurrentRow.Cells["EventName"].Value.ToString();

                // Open the Ticket Manager form for the selected event
                Ticket_Manager ticketForm = new Ticket_Manager(eventID, eventName);
                ticketForm.Show();
            }
            else
            {
                MessageBox.Show("Please select an event to manage tickets.");
            }
        }

        // Unused event handlers (can be removed if not needed)
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void txtDate_TextChanged(object sender, EventArgs e) { }
    }
}