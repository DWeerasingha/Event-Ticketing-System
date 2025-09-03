namespace Event_Ticket_Handling
{
    partial class Ticket_Purchase
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
            btnLogout = new Button();
            btnViewMyTickets = new Button();
            btnBuyTckets = new Button();
            dgvTickets = new DataGridView();
            label1 = new Label();
            lblWelcome = new Label();
            txtQuantity = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.IndianRed;
            btnLogout.Location = new Point(676, 398);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(108, 39);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnViewMyTickets
            // 
            btnViewMyTickets.BackColor = Color.Gold;
            btnViewMyTickets.Location = new Point(478, 397);
            btnViewMyTickets.Margin = new Padding(3, 2, 3, 2);
            btnViewMyTickets.Name = "btnViewMyTickets";
            btnViewMyTickets.Size = new Size(164, 41);
            btnViewMyTickets.TabIndex = 10;
            btnViewMyTickets.Text = "My Tickets";
            btnViewMyTickets.UseVisualStyleBackColor = false;
            btnViewMyTickets.Click += btnViewMyTickets_Click;
            // 
            // btnBuyTckets
            // 
            btnBuyTckets.BackColor = Color.LightGreen;
            btnBuyTckets.Location = new Point(277, 398);
            btnBuyTckets.Margin = new Padding(3, 2, 3, 2);
            btnBuyTckets.Name = "btnBuyTckets";
            btnBuyTckets.Size = new Size(164, 41);
            btnBuyTckets.TabIndex = 9;
            btnBuyTckets.Text = "Buy Ticket";
            btnBuyTckets.UseVisualStyleBackColor = false;
            btnBuyTckets.Click += btnBuyTckets_Click;
            // 
            // dgvTickets
            // 
            dgvTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTickets.Location = new Point(277, 176);
            dgvTickets.Margin = new Padding(3, 2, 3, 2);
            dgvTickets.Name = "dgvTickets";
            dgvTickets.ReadOnly = true;
            dgvTickets.RowHeadersWidth = 51;
            dgvTickets.Size = new Size(562, 141);
            dgvTickets.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(277, 143);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 7;
            label1.Text = "Our Tickets";
            label1.Click += label1_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(260, 122);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(0, 15);
            lblWelcome.TabIndex = 6;
            lblWelcome.Click += lblWelcome_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = SystemColors.GradientActiveCaption;
            txtQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(404, 340);
            txtQuantity.Margin = new Padding(3, 2, 3, 2);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(110, 29);
            txtQuantity.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(277, 342);
            label2.Name = "label2";
            label2.Size = new Size(121, 21);
            label2.TabIndex = 13;
            label2.Text = "Ticket Quantity :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Gemini_Generated_Image_z92apgz92apgz92a;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 437);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Light", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(277, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(377, 64);
            textBox1.TabIndex = 15;
            textBox1.Text = "Ticket Dashboard";
            // 
            // Ticket_Purchase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(843, 461);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(txtQuantity);
            Controls.Add(btnLogout);
            Controls.Add(btnViewMyTickets);
            Controls.Add(btnBuyTckets);
            Controls.Add(dgvTickets);
            Controls.Add(label1);
            Controls.Add(lblWelcome);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Ticket_Purchase";
            Text = "Ticket_Purchase";
            Load += Ticket_Purchase_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTickets).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogout;
        private Button btnViewMyTickets;
        private Button btnBuyTckets;
        private DataGridView dgvTickets;
        private Label label1;
        private Label lblWelcome;
        private TextBox txtQuantity;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox textBox1;
    }
}