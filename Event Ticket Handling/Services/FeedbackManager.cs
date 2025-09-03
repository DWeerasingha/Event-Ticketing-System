using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Ticket_Handling
{
    internal class FeedbackManager
    {
        private string connStr = "server=localhost;user=root;password=;database=eventdata;";

        // Add feedback to the database
        public bool AddFeedback(int attendeeId, int eventId, int rating, string comment)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "INSERT INTO tbl_feedback (AttendeeID, EventID, Rating, Comment) " +
                               "VALUES (@AttendeeID, @EventID, @Rating, @Comment)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AttendeeID", attendeeId);
                    cmd.Parameters.AddWithValue("@EventID", eventId);
                    cmd.Parameters.AddWithValue("@Rating", rating);
                    cmd.Parameters.AddWithValue("@Comment", comment);

                    return cmd.ExecuteNonQuery() > 0; // returns true if insert succeeded
                }
            }
        }

        // Get all feedback for a specific event
        public DataTable GetFeedbackForEvent(int eventId)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT f.FeedbackID, a.FullName, f.Rating, f.Comment, f.CreatedAt " +
                               "FROM tbl_feedback f " +
                               "JOIN tbl_attendee a ON f.AttendeeID = a.AttendeeID " +
                               "WHERE f.EventID = @EventID " +
                               "ORDER BY f.CreatedAt DESC";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EventID", eventId);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        // Calculate average rating for an event
        public double GetAverageRating(int eventId)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT AVG(Rating) FROM tbl_feedback WHERE EventID = @EventID";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EventID", eventId);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                        return Convert.ToDouble(result);
                    else
                        return 0; // no feedback yet
                }
            }
        }

        // Get all feedback across all events (for admin)
        public DataTable GetAllFeedback()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = @"
                    SELECT f.FeedbackID, e.EventName, a.FullName, f.Rating, f.Comment, f.CreatedAt
                    FROM tbl_feedback f
                    JOIN tbl_attendee a ON f.AttendeeID = a.AttendeeID
                    JOIN tbl_events e ON f.EventID = e.EventID
                    ORDER BY f.CreatedAt DESC";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
    }
}