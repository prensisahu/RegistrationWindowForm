namespace R_S
{
    partial class Forgot
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
            pictureBox1 = new PictureBox();
            label8 = new Label();
            label2 = new Label();
            label1 = new Label();
            MobileorEmail = new TextBox();
            label3 = new Label();
            txtOTP = new Button();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label7 = new Label();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_forgot_password_100;
            pictureBox1.Location = new Point(179, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 109);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(131, 207);
            label8.Name = "label8";
            label8.Size = new Size(212, 24);
            label8.TabIndex = 3;
            label8.Text = "Trouble logging in?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(72, 244);
            label2.Name = "label2";
            label2.Size = new Size(315, 23);
            label2.TabIndex = 4;
            label2.Text = "Enter your email, or phonewe'll";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 267);
            label1.Name = "label1";
            label1.Size = new Size(451, 23);
            label1.TabIndex = 5;
            label1.Text = "send you a otp to get back into your account.";
            // 
            // MobileorEmail
            // 
            MobileorEmail.BorderStyle = BorderStyle.FixedSingle;
            MobileorEmail.Cursor = Cursors.IBeam;
            MobileorEmail.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MobileorEmail.Location = new Point(54, 360);
            MobileorEmail.Multiline = true;
            MobileorEmail.Name = "MobileorEmail";
            MobileorEmail.Size = new Size(362, 34);
            MobileorEmail.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 334);
            label3.Name = "label3";
            label3.Size = new Size(157, 23);
            label3.TabIndex = 6;
            label3.Text = "Phone or Email";
            // 
            // txtOTP
            // 
            txtOTP.BackColor = Color.FromArgb(0, 192, 0);
            txtOTP.Cursor = Cursors.Hand;
            txtOTP.FlatAppearance.BorderSize = 0;
            txtOTP.FlatAppearance.MouseDownBackColor = Color.Green;
            txtOTP.FlatStyle = FlatStyle.Flat;
            txtOTP.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOTP.ForeColor = Color.White;
            txtOTP.Location = new Point(54, 427);
            txtOTP.Name = "txtOTP";
            txtOTP.Size = new Size(362, 39);
            txtOTP.TabIndex = 12;
            txtOTP.Text = "Send login otp";
            txtOTP.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(212, 546);
            label10.Name = "label10";
            label10.Size = new Size(36, 21);
            label10.TabIndex = 35;
            label10.Text = "OR";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(247, 546);
            label11.Name = "label11";
            label11.Size = new Size(165, 20);
            label11.TabIndex = 34;
            label11.Text = "--------------------------";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(50, 546);
            label12.Name = "label12";
            label12.Size = new Size(165, 20);
            label12.TabIndex = 33;
            label12.Text = "--------------------------";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(447, 9);
            label7.Name = "label7";
            label7.Size = new Size(22, 21);
            label7.TabIndex = 38;
            label7.Text = "X";
            label7.Click += label7_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            button2.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(49, 605);
            button2.Name = "button2";
            button2.Size = new Size(362, 39);
            button2.TabIndex = 39;
            button2.Text = "create new account";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 64, 64);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Green;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(50, 701);
            button3.Name = "button3";
            button3.Size = new Size(362, 39);
            button3.TabIndex = 40;
            button3.Text = "Back to login";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Forgot
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 792);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(txtOTP);
            Controls.Add(MobileorEmail);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Forgot";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forgot";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label8;
        private Label label2;
        private Label label1;
        private TextBox MobileorEmail;
        private Label label3;
        private Button txtOTP;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label7;
        private Button button2;
        private Button button3;
    }
}