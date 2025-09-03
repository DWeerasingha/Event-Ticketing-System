namespace Event_Ticket_Handling
{
    partial class FeedbackForm
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
            lblEventName = new Label();
            numRating = new NumericUpDown();
            txtComment = new TextBox();
            btnSubmit = new Button();
            btnCancel = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numRating).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblEventName
            // 
            lblEventName.AutoSize = true;
            lblEventName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEventName.Location = new Point(287, 85);
            lblEventName.Name = "lblEventName";
            lblEventName.Size = new Size(48, 21);
            lblEventName.TabIndex = 0;
            lblEventName.Text = "Event";
            lblEventName.Click += lblEventName_Click;
            // 
            // numRating
            // 
            numRating.Location = new Point(287, 146);
            numRating.Name = "numRating";
            numRating.Size = new Size(120, 23);
            numRating.TabIndex = 1;
            // 
            // txtComment
            // 
            txtComment.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtComment.Location = new Point(287, 218);
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(331, 22);
            txtComment.TabIndex = 2;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Gold;
            btnSubmit.Location = new Point(287, 331);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(98, 32);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.IndianRed;
            btnCancel.Location = new Point(391, 331);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(95, 32);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Close";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Gemini_Generated_Image_z92apgz92apgz92a;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 339);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(287, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(131, 22);
            textBox1.TabIndex = 6;
            textBox1.Text = "Rate us out of 5 :";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(287, 190);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(147, 22);
            textBox2.TabIndex = 7;
            textBox2.Text = "Your Comment :";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI Light", 24F);
            textBox3.Location = new Point(287, 23);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(364, 43);
            textBox3.TabIndex = 8;
            textBox3.Text = "Tell Us What You Think...";
            // 
            // FeedbackForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(715, 391);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(txtComment);
            Controls.Add(numRating);
            Controls.Add(lblEventName);
            Name = "FeedbackForm";
            Text = "FeedbackForm";
            Load += FeedbackForm_Load;
            ((System.ComponentModel.ISupportInitialize)numRating).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEventName;
        private NumericUpDown numRating;
        private TextBox txtComment;
        private Button btnSubmit;
        private Button btnCancel;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}