namespace Event_Ticket_Handling
{
    partial class AdminFeedbackForm
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
            cmbEvents = new ComboBox();
            btnLoad = new Button();
            btnShowAll = new Button();
            dgvFeedback = new DataGridView();
            lblAvgRating = new Label();
            btnClose = new Button();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvFeedback).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbEvents
            // 
            cmbEvents.FormattingEnabled = true;
            cmbEvents.Location = new Point(295, 82);
            cmbEvents.Name = "cmbEvents";
            cmbEvents.Size = new Size(215, 23);
            cmbEvents.TabIndex = 0;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.SpringGreen;
            btnLoad.Location = new Point(295, 111);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(113, 33);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load Event";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.BackColor = Color.Gold;
            btnShowAll.Location = new Point(296, 204);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(122, 33);
            btnShowAll.TabIndex = 2;
            btnShowAll.Text = "Show All Feedback";
            btnShowAll.UseVisualStyleBackColor = false;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // dgvFeedback
            // 
            dgvFeedback.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFeedback.Location = new Point(296, 243);
            dgvFeedback.Name = "dgvFeedback";
            dgvFeedback.Size = new Size(568, 224);
            dgvFeedback.TabIndex = 3;
            // 
            // lblAvgRating
            // 
            lblAvgRating.AutoSize = true;
            lblAvgRating.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAvgRating.Location = new Point(296, 147);
            lblAvgRating.Name = "lblAvgRating";
            lblAvgRating.Size = new Size(159, 21);
            lblAvgRating.TabIndex = 4;
            lblAvgRating.Text = "Show Average Rating";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.IndianRed;
            btnClose.Location = new Point(424, 204);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(114, 33);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Gemini_Generated_Image_z92apgz92apgz92a;
            pictureBox1.Location = new Point(3, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(274, 479);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(296, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(340, 50);
            textBox2.TabIndex = 8;
            textBox2.Text = "Ratings & Feedback";
            // 
            // AdminFeedbackForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(876, 491);
            Controls.Add(textBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnClose);
            Controls.Add(lblAvgRating);
            Controls.Add(dgvFeedback);
            Controls.Add(btnShowAll);
            Controls.Add(btnLoad);
            Controls.Add(cmbEvents);
            Name = "AdminFeedbackForm";
            Text = "AdminFeedbackForm";
            Load += AdminFeedbackForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFeedback).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbEvents;
        private Button btnLoad;
        private Button btnShowAll;
        private DataGridView dgvFeedback;
        private Label lblAvgRating;
        private Button btnClose;
        private PictureBox pictureBox1;
        private TextBox textBox2;
    }
}