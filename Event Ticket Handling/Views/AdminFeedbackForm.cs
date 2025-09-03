using Event_Ticket_Handling.Services;
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
    public partial class AdminFeedbackForm : Form
    {
        private FeedbackManager feedbackManager;
        private EventService eventService;

        public AdminFeedbackForm()
        {
            InitializeComponent();
            feedbackManager = new FeedbackManager();
            eventService = new EventService();
        }

        // Runs when the form opens
        private void AdminFeedbackForm_Load(object sender, EventArgs e)
        {
            LoadEventsToCombo();
            // Optionally show all feedback initially:
            // LoadAllFeedback();
        }

        // Fill combo box with events
        private void LoadEventsToCombo()
        {
            try
            {
                DataTable dtEvents = eventService.GetAllEvents();
                cmbEvents.DataSource = dtEvents;
                cmbEvents.DisplayMember = "EventName"; // visible text
                cmbEvents.ValueMember = "EventID";     // actual value (int)
                cmbEvents.SelectedIndex = -1; // no selection initially
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading events: " + ex.Message);
            }
        }

        // When admin clicks "Load" (feedback for selected event)
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (cmbEvents.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an event first.", "Select Event", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int eventId = Convert.ToInt32(cmbEvents.SelectedValue);
            LoadFeedbackForEvent(eventId);
        }

        // Fill the DataGridView and show average rating
        private void LoadFeedbackForEvent(int eventId)
        {
            try
            {
                DataTable dt = feedbackManager.GetFeedbackForEvent(eventId);
                dgvFeedback.DataSource = dt;

                double avg = feedbackManager.GetAverageRating(eventId);
                lblAvgRating.Text = $"Average Rating: {avg:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading feedback: " + ex.Message);
            }
        }

        // Optional: show all feedback across events
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = feedbackManager.GetAllFeedback();
                dgvFeedback.DataSource = dt;
                lblAvgRating.Text = "Average Rating: -";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading all feedback: " + ex.Message);
            }
        }

        // Close the form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}