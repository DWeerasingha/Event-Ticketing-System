namespace Event_Ticket_Handling
{
    partial class AttendeeDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblWelcome = new Label();
            label1 = new Label();
            dgvEvents = new DataGridView();
            btnRegisterForEvent = new Button();
            btnViewMyTickets = new Button();
            btnLogout = new Button();
            rate_event = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvEvents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI Light", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(362, 12);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(588, 65);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "WELCOME ! attendee name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(337, 136);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 1;
            label1.Text = "Our Events";
            // 
            // dgvEvents
            // 
            dgvEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEvents.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgvEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEvents.Location = new Point(337, 158);
            dgvEvents.Margin = new Padding(3, 2, 3, 2);
            dgvEvents.Name = "dgvEvents";
            dgvEvents.ReadOnly = true;
            dgvEvents.RowHeadersWidth = 51;
            dgvEvents.Size = new Size(692, 249);
            dgvEvents.TabIndex = 2;
            // 
            // btnRegisterForEvent
            // 
            btnRegisterForEvent.BackColor = Color.Aqua;
            btnRegisterForEvent.Location = new Point(337, 428);
            btnRegisterForEvent.Margin = new Padding(3, 2, 3, 2);
            btnRegisterForEvent.Name = "btnRegisterForEvent";
            btnRegisterForEvent.Size = new Size(164, 41);
            btnRegisterForEvent.TabIndex = 3;
            btnRegisterForEvent.Text = "Register Here";
            btnRegisterForEvent.UseVisualStyleBackColor = false;
            btnRegisterForEvent.Click += button1_Click;
            // 
            // btnViewMyTickets
            // 
            btnViewMyTickets.BackColor = Color.LightGreen;
            btnViewMyTickets.Location = new Point(517, 428);
            btnViewMyTickets.Margin = new Padding(3, 2, 3, 2);
            btnViewMyTickets.Name = "btnViewMyTickets";
            btnViewMyTickets.Size = new Size(164, 41);
            btnViewMyTickets.TabIndex = 4;
            btnViewMyTickets.Text = "My Tickets";
            btnViewMyTickets.UseVisualStyleBackColor = false;
            btnViewMyTickets.Click += button2_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.IndianRed;
            btnLogout.Location = new Point(868, 428);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(110, 41);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Close";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // rate_event
            // 
            rate_event.BackColor = Color.Plum;
            rate_event.Location = new Point(697, 428);
            rate_event.Name = "rate_event";
            rate_event.Size = new Size(151, 42);
            rate_event.TabIndex = 6;
            rate_event.Text = "Rate for Event";
            rate_event.UseVisualStyleBackColor = false;
            rate_event.Click += rate_event_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Gemini_Generated_Image_z92apgz92apgz92a;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(275, 485);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // AttendeeDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1052, 509);
            Controls.Add(pictureBox1);
            Controls.Add(rate_event);
            Controls.Add(btnLogout);
            Controls.Add(btnViewMyTickets);
            Controls.Add(btnRegisterForEvent);
            Controls.Add(dgvEvents);
            Controls.Add(label1);
            Controls.Add(lblWelcome);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AttendeeDashboard";
            Text = "AttendeeDashboard";
            Load += AttendeeDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEvents).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Label label1;
        private DataGridView dgvEvents;
        private Button btnRegisterForEvent;
        private Button btnViewMyTickets;
        private Button btnLogout;
        private Button rate_event;
        private PictureBox pictureBox1;
    }
}