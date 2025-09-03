namespace Event_Ticket_Handling
{
    partial class Event_Manager
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
            btnAddevent = new Button();
            btnUpdateevent = new Button();
            btnDeleteevent = new Button();
            label1 = new Label();
            txtEventName = new TextBox();
            txtEventID = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtVenue = new TextBox();
            label4 = new Label();
            txtDescription = new TextBox();
            label5 = new Label();
            dataGridViewEvents = new DataGridView();
            txtDate = new DateTimePicker();
            btnManagetickets = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEvents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAddevent
            // 
            btnAddevent.BackColor = Color.GreenYellow;
            btnAddevent.Location = new Point(283, 444);
            btnAddevent.Margin = new Padding(3, 2, 3, 2);
            btnAddevent.Name = "btnAddevent";
            btnAddevent.Size = new Size(140, 37);
            btnAddevent.TabIndex = 0;
            btnAddevent.Text = "ADD";
            btnAddevent.UseVisualStyleBackColor = false;
            btnAddevent.Click += btnAddevent_Click;
            // 
            // btnUpdateevent
            // 
            btnUpdateevent.BackColor = Color.Gold;
            btnUpdateevent.Location = new Point(450, 444);
            btnUpdateevent.Margin = new Padding(3, 2, 3, 2);
            btnUpdateevent.Name = "btnUpdateevent";
            btnUpdateevent.Size = new Size(146, 37);
            btnUpdateevent.TabIndex = 1;
            btnUpdateevent.Text = "UPDATE";
            btnUpdateevent.UseVisualStyleBackColor = false;
            btnUpdateevent.Click += btnUpdateevent_Click;
            // 
            // btnDeleteevent
            // 
            btnDeleteevent.BackColor = Color.LightCoral;
            btnDeleteevent.Location = new Point(623, 444);
            btnDeleteevent.Margin = new Padding(3, 2, 3, 2);
            btnDeleteevent.Name = "btnDeleteevent";
            btnDeleteevent.Size = new Size(140, 37);
            btnDeleteevent.TabIndex = 2;
            btnDeleteevent.Text = "DELETE";
            btnDeleteevent.UseVisualStyleBackColor = false;
            btnDeleteevent.Click += btnDeleteevent_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(283, 356);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 4;
            label1.Text = "Event Name";
            // 
            // txtEventName
            // 
            txtEventName.Location = new Point(360, 353);
            txtEventName.Margin = new Padding(3, 2, 3, 2);
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(110, 23);
            txtEventName.TabIndex = 5;
            // 
            // txtEventID
            // 
            txtEventID.Location = new Point(549, 356);
            txtEventID.Margin = new Padding(3, 2, 3, 2);
            txtEventID.Name = "txtEventID";
            txtEventID.Size = new Size(110, 23);
            txtEventID.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(493, 359);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 6;
            label2.Text = "Event ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(678, 361);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 8;
            label3.Text = "Date";
            // 
            // txtVenue
            // 
            txtVenue.Location = new Point(360, 393);
            txtVenue.Margin = new Padding(3, 2, 3, 2);
            txtVenue.Name = "txtVenue";
            txtVenue.Size = new Size(110, 23);
            txtVenue.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(315, 396);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 10;
            label4.Text = "Venue";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(549, 396);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(110, 23);
            txtDescription.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(476, 401);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 12;
            label5.Text = "Description";
            // 
            // dataGridViewEvents
            // 
            dataGridViewEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEvents.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEvents.Location = new Point(283, 109);
            dataGridViewEvents.Margin = new Padding(3, 2, 3, 2);
            dataGridViewEvents.Name = "dataGridViewEvents";
            dataGridViewEvents.ReadOnly = true;
            dataGridViewEvents.RowHeadersWidth = 51;
            dataGridViewEvents.Size = new Size(635, 223);
            dataGridViewEvents.TabIndex = 14;
            dataGridViewEvents.CellContentClick += dataGridViewEvents_CellContentClick;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(715, 356);
            txtDate.Margin = new Padding(3, 2, 3, 2);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(203, 23);
            txtDate.TabIndex = 15;
            txtDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btnManagetickets
            // 
            btnManagetickets.BackColor = Color.MediumTurquoise;
            btnManagetickets.Location = new Point(283, 513);
            btnManagetickets.Margin = new Padding(3, 2, 3, 2);
            btnManagetickets.Name = "btnManagetickets";
            btnManagetickets.Size = new Size(480, 37);
            btnManagetickets.TabIndex = 16;
            btnManagetickets.Text = "MANAGE TICKETS";
            btnManagetickets.UseVisualStyleBackColor = false;
            btnManagetickets.Click += btnManagetickets_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Gemini_Generated_Image_z92apgz92apgz92a;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(265, 538);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Light", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(450, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(371, 64);
            textBox1.TabIndex = 18;
            textBox1.Text = "Event Dashboard";
            // 
            // Event_Manager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(930, 561);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(btnManagetickets);
            Controls.Add(txtDate);
            Controls.Add(dataGridViewEvents);
            Controls.Add(txtDescription);
            Controls.Add(label5);
            Controls.Add(txtVenue);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtEventID);
            Controls.Add(label2);
            Controls.Add(txtEventName);
            Controls.Add(label1);
            Controls.Add(btnDeleteevent);
            Controls.Add(btnUpdateevent);
            Controls.Add(btnAddevent);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Event_Manager";
            Text = "Event_Manager";
            Load += Event_Manager_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEvents).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddevent;
        private Button btnUpdateevent;
        private Button btnDeleteevent;
        private Label label1;
        private TextBox txtEventName;
        private TextBox txtEventID;
        private Label label2;
        private Label label3;
        private TextBox txtVenue;
        private Label label4;
        private TextBox txtDescription;
        private Label label5;
        private DataGridView dataGridViewEvents;
        private DateTimePicker txtDate;
        private Button btnManagetickets;
        private PictureBox pictureBox1;
        private TextBox textBox1;
    }
}