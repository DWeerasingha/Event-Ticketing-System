namespace Event_Ticket_Handling
{
    partial class My_Tickets
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
            dgvMyTickets = new DataGridView();
            btnCancelTicket = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvMyTickets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvMyTickets
            // 
            dgvMyTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMyTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyTickets.Location = new Point(266, 124);
            dgvMyTickets.Margin = new Padding(3, 2, 3, 2);
            dgvMyTickets.Name = "dgvMyTickets";
            dgvMyTickets.ReadOnly = true;
            dgvMyTickets.RowHeadersWidth = 51;
            dgvMyTickets.Size = new Size(597, 206);
            dgvMyTickets.TabIndex = 0;
            // 
            // btnCancelTicket
            // 
            btnCancelTicket.BackColor = Color.SandyBrown;
            btnCancelTicket.Location = new Point(266, 345);
            btnCancelTicket.Margin = new Padding(3, 2, 3, 2);
            btnCancelTicket.Name = "btnCancelTicket";
            btnCancelTicket.Size = new Size(141, 34);
            btnCancelTicket.TabIndex = 1;
            btnCancelTicket.Text = "CANCEL TICKET";
            btnCancelTicket.UseVisualStyleBackColor = false;
            btnCancelTicket.Click += btnCancelTicket_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(441, 12);
            label1.Name = "label1";
            label1.Size = new Size(237, 65);
            label1.TabIndex = 2;
            label1.Text = "My Tickets";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Gemini_Generated_Image_z92apgz92apgz92a;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 395);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // My_Tickets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(875, 419);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnCancelTicket);
            Controls.Add(dgvMyTickets);
            Margin = new Padding(3, 2, 3, 2);
            Name = "My_Tickets";
            Text = "My_Tickets";
            Load += My_Tickets_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMyTickets).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMyTickets;
        private Button btnCancelTicket;
        private Label label1;
        private PictureBox pictureBox1;
    }
}