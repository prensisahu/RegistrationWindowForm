namespace R_S
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            MobileorEmail = new TextBox();
            FullnameRegistration = new TextBox();
            PaaswordRegistration = new TextBox();
            label5 = new Label();
            ShowPassword = new CheckBox();
            button1 = new Button();
            panel1 = new Panel();
            label9 = new Label();
            label8 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 152);
            label1.Name = "label1";
            label1.Size = new Size(161, 23);
            label1.TabIndex = 0;
            label1.Text = "Mobile or Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 241);
            label2.Name = "label2";
            label2.Size = new Size(109, 23);
            label2.TabIndex = 1;
            label2.Text = "Full name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 331);
            label3.Name = "label3";
            label3.Size = new Size(102, 23);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(445, 9);
            label4.Name = "label4";
            label4.Size = new Size(22, 21);
            label4.TabIndex = 3;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // MobileorEmail
            // 
            MobileorEmail.BorderStyle = BorderStyle.FixedSingle;
            MobileorEmail.Cursor = Cursors.IBeam;
            MobileorEmail.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MobileorEmail.Location = new Point(54, 178);
            MobileorEmail.Multiline = true;
            MobileorEmail.Name = "MobileorEmail";
            MobileorEmail.Size = new Size(362, 34);
            MobileorEmail.TabIndex = 4;
            // 
            // FullnameRegistration
            // 
            FullnameRegistration.BorderStyle = BorderStyle.FixedSingle;
            FullnameRegistration.Cursor = Cursors.IBeam;
            FullnameRegistration.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FullnameRegistration.Location = new Point(54, 267);
            FullnameRegistration.Multiline = true;
            FullnameRegistration.Name = "FullnameRegistration";
            FullnameRegistration.Size = new Size(362, 34);
            FullnameRegistration.TabIndex = 5;
            // 
            // PaaswordRegistration
            // 
            PaaswordRegistration.BorderStyle = BorderStyle.FixedSingle;
            PaaswordRegistration.Cursor = Cursors.IBeam;
            PaaswordRegistration.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PaaswordRegistration.Location = new Point(54, 357);
            PaaswordRegistration.Multiline = true;
            PaaswordRegistration.Name = "PaaswordRegistration";
            PaaswordRegistration.PasswordChar = '*';
            PaaswordRegistration.Size = new Size(362, 34);
            PaaswordRegistration.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bookman Old Style", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(143, 54);
            label5.Name = "label5";
            label5.Size = new Size(179, 33);
            label5.TabIndex = 7;
            label5.Text = "Registration";
            // 
            // ShowPassword
            // 
            ShowPassword.AutoSize = true;
            ShowPassword.Cursor = Cursors.Hand;
            ShowPassword.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowPassword.Location = new Point(270, 397);
            ShowPassword.Name = "ShowPassword";
            ShowPassword.Size = new Size(146, 23);
            ShowPassword.TabIndex = 10;
            ShowPassword.Text = "Show Password";
            ShowPassword.UseVisualStyleBackColor = true;
            ShowPassword.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Green;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(54, 473);
            button1.Name = "button1";
            button1.Size = new Size(362, 39);
            button1.TabIndex = 11;
            button1.Text = "Sign up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(54, 638);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 82);
            panel1.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Cursor = Cursors.Hand;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(0, 192, 0);
            label9.Location = new Point(138, 40);
            label9.Name = "label9";
            label9.Size = new Size(75, 24);
            label9.TabIndex = 13;
            label9.Text = "Log in";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(89, 17);
            label8.Name = "label8";
            label8.Size = new Size(186, 23);
            label8.TabIndex = 2;
            label8.Text = "Have an account?";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(216, 569);
            label10.Name = "label10";
            label10.Size = new Size(36, 21);
            label10.TabIndex = 32;
            label10.Text = "OR";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(251, 569);
            label11.Name = "label11";
            label11.Size = new Size(165, 20);
            label11.TabIndex = 31;
            label11.Text = "--------------------------";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(54, 569);
            label12.Name = "label12";
            label12.Size = new Size(165, 20);
            label12.TabIndex = 30;
            label12.Text = "--------------------------";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 792);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(ShowPassword);
            Controls.Add(label5);
            Controls.Add(PaaswordRegistration);
            Controls.Add(FullnameRegistration);
            Controls.Add(MobileorEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox MobileorEmail;
        private TextBox FullnameRegistration;
        private TextBox PaaswordRegistration;
        private Label label5;
        private CheckBox ShowPassword;
        private Button button1;
        private Panel panel1;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}
