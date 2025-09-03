namespace Event_Ticket_Handling
{
    partial class Admin_Dashboard
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
            btnManageevent = new Button();
            btnManageattendees = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            btnViewRatings = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnManageevent
            // 
            btnManageevent.BackColor = Color.Moccasin;
            btnManageevent.Location = new Point(367, 105);
            btnManageevent.Margin = new Padding(3, 2, 3, 2);
            btnManageevent.Name = "btnManageevent";
            btnManageevent.Size = new Size(262, 42);
            btnManageevent.TabIndex = 0;
            btnManageevent.Text = "MANAGE EVENTS";
            btnManageevent.UseVisualStyleBackColor = false;
            btnManageevent.Click += button1_Click;
            // 
            // btnManageattendees
            // 
            btnManageattendees.BackColor = Color.Orchid;
            btnManageattendees.Location = new Point(367, 160);
            btnManageattendees.Margin = new Padding(3, 2, 3, 2);
            btnManageattendees.Name = "btnManageattendees";
            btnManageattendees.Size = new Size(262, 50);
            btnManageattendees.TabIndex = 2;
            btnManageattendees.Text = "VIEW ATTENDEES";
            btnManageattendees.UseVisualStyleBackColor = false;
            btnManageattendees.Click += btnManageattendees_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.PaleGreen;
            button1.Location = new Point(367, 224);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(262, 48);
            button1.TabIndex = 3;
            button1.Text = "VIEW SALES\r\n\r\n";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.Gemini_Generated_Image_z92apgz92apgz92a;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 348);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Light", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(367, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 64);
            textBox1.TabIndex = 5;
            textBox1.Text = "Select Task...";
            // 
            // btnViewRatings
            // 
            btnViewRatings.BackColor = Color.PaleTurquoise;
            btnViewRatings.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewRatings.Location = new Point(367, 292);
            btnViewRatings.Name = "btnViewRatings";
            btnViewRatings.Size = new Size(262, 46);
            btnViewRatings.TabIndex = 6;
            btnViewRatings.Text = "View Ratings";
            btnViewRatings.UseVisualStyleBackColor = false;
            btnViewRatings.Click += btnViewRatings_Click;
            // 
            // Admin_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(707, 372);
            Controls.Add(btnViewRatings);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(btnManageattendees);
            Controls.Add(btnManageevent);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Admin_Dashboard";
            Text = "Admin_Dashboard";
            Load += Admin_Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnManageevent;
        private Button btnManageattendees;
        private Button button1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button btnViewRatings;
    }
}