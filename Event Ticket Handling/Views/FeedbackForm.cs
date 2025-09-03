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
    public partial class FeedbackForm : Form
    {
        private int attendeeId;
        private int eventId;
        private FeedbackManager feedbackManager;

        // Constructor to pass attendee ID, event ID, and event name
        public FeedbackForm(int attendeeId, int eventId, string eventName)
        {
            InitializeComponent();

            this.attendeeId = attendeeId;
            this.eventId = eventId;
            feedbackManager = new FeedbackManager();

            // Set event name label
            lblEventName.Text = $"Event: {eventName}";

            // Set numeric rating bounds
            numRating.Minimum = 1;
            numRating.Maximum = 5;

            // Set button texts
            btnSubmit.Text = "Submit";
            btnCancel.Text = "Cancel";

            // Make comment box multiline for better usability
            txtComment.Multiline = true;
            txtComment.Width = 400;
            txtComment.Height = 100;
        }

        // Submit feedback
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int rating = (int)numRating.Value;
            string comment = txtComment.Text.Trim();

            if (string.IsNullOrEmpty(comment))
            {
                MessageBox.Show("Please enter a comment.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool success = feedbackManager.AddFeedback(attendeeId, eventId, rating, comment);

                if (success)
                {
                    MessageBox.Show("Thank you for your feedback!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to submit feedback. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cancel button closes the form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FeedbackForm_Load(object sender, EventArgs e)
        {

        }

        private void lblEventName_Click(object sender, EventArgs e)
        {

        }
    }
}
