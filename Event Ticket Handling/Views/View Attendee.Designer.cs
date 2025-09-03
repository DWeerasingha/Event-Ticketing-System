namespace Event_Ticket_Handling
{
    partial class View_Attendee
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
            dgvAttendees = new DataGridView();
            cmbEvents = new ComboBox();
            label1 = new Label();
            btnShowAttendees = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvAttendees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvAttendees
            // 
            dgvAttendees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttendees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendees.Location = new Point(256, 206);
            dgvAttendees.Margin = new Padding(3, 2, 3, 2);
            dgvAttendees.Name = "dgvAttendees";
            dgvAttendees.ReadOnly = true;
            dgvAttendees.RowHeadersWidth = 51;
            dgvAttendees.Size = new Size(521, 217);
            dgvAttendees.TabIndex = 0;
            dgvAttendees.CellContentClick += dgvAttendees_CellContentClick;
            // 
            // cmbEvents
            // 
            cmbEvents.FormattingEnabled = true;
            cmbEvents.Location = new Point(358, 134);
            cmbEvents.Margin = new Padding(3, 2, 3, 2);
            cmbEvents.Name = "cmbEvents";
            cmbEvents.Size = new Size(150, 23);
            cmbEvents.TabIndex = 1;
            cmbEvents.SelectedIndexChanged += cmbEvents_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(259, 134);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 2;
            label1.Text = "Select Event";
            // 
            // btnShowAttendees
            // 
            btnShowAttendees.BackColor = Color.IndianRed;
            btnShowAttendees.Location = new Point(358, 170);
            btnShowAttendees.Margin = new Padding(3, 2, 3, 2);
            btnShowAttendees.Name = "btnShowAttendees";
            btnShowAttendees.Size = new Size(150, 32);
            btnShowAttendees.TabIndex = 3;
            btnShowAttendees.Text = "Show all Attendee";
            btnShowAttendees.UseVisualStyleBackColor = false;
            btnShowAttendees.Click += btnShowAttendees_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Gemini_Generated_Image_z92apgz92apgz92a;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 424);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Light", 36F);
            textBox1.Location = new Point(333, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(409, 64);
            textBox1.TabIndex = 5;
            textBox1.Text = "Attendee Summery";
            // 
            // View_Attendee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(789, 448);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(btnShowAttendees);
            Controls.Add(label1);
            Controls.Add(cmbEvents);
            Controls.Add(dgvAttendees);
            Margin = new Padding(3, 2, 3, 2);
            Name = "View_Attendee";
            Text = "View_Attendee";
            Load += View_Attendee_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAttendees).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAttendees;
        private ComboBox cmbEvents;
        private Label label1;
        private Button btnShowAttendees;
        private PictureBox pictureBox1;
        private TextBox textBox1;
    }
}