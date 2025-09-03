namespace Event_Ticket_Handling
{
    partial class View_Sales
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
            dgvsales = new DataGridView();
            btnShowAttendees = new Button();
            label1 = new Label();
            cmbEvents = new ComboBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvsales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvsales
            // 
            dgvsales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvsales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvsales.Location = new Point(256, 211);
            dgvsales.Margin = new Padding(3, 2, 3, 2);
            dgvsales.Name = "dgvsales";
            dgvsales.ReadOnly = true;
            dgvsales.RowHeadersWidth = 51;
            dgvsales.Size = new Size(646, 217);
            dgvsales.TabIndex = 0;
            dgvsales.CellContentClick += dgvsales_CellContentClick;
            // 
            // btnShowAttendees
            // 
            btnShowAttendees.BackColor = Color.IndianRed;
            btnShowAttendees.Location = new Point(357, 155);
            btnShowAttendees.Margin = new Padding(3, 2, 3, 2);
            btnShowAttendees.Name = "btnShowAttendees";
            btnShowAttendees.Size = new Size(136, 39);
            btnShowAttendees.TabIndex = 6;
            btnShowAttendees.Text = "View Sales";
            btnShowAttendees.UseVisualStyleBackColor = false;
            btnShowAttendees.Click += btnShowAttendees_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(258, 121);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 5;
            label1.Text = "Select Event";
            // 
            // cmbEvents
            // 
            cmbEvents.FormattingEnabled = true;
            cmbEvents.Location = new Point(357, 119);
            cmbEvents.Margin = new Padding(3, 2, 3, 2);
            cmbEvents.Name = "cmbEvents";
            cmbEvents.Size = new Size(136, 23);
            cmbEvents.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Gemini_Generated_Image_z92apgz92apgz92a;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 416);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Light", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(402, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(357, 64);
            textBox1.TabIndex = 8;
            textBox1.Text = "Sales Summmery";
            // 
            // View_Sales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(918, 440);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(btnShowAttendees);
            Controls.Add(label1);
            Controls.Add(cmbEvents);
            Controls.Add(dgvsales);
            Margin = new Padding(3, 2, 3, 2);
            Name = "View_Sales";
            Text = "View_Sales";
            Load += View_Sales_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvsales).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvsales;
        private Button btnShowAttendees;
        private Label label1;
        private ComboBox cmbEvents;
        private PictureBox pictureBox1;
        private TextBox textBox1;
    }
}