namespace R_S
{
    partial class Form2
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
            panel1 = new Panel();
            label9 = new Label();
            label8 = new Label();
            button1 = new Button();
            ShowPassword2 = new CheckBox();
            label5 = new Label();
            PaaswordTextBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label6 = new Label();
            label7 = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(54, 629);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 82);
            panel1.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Cursor = Cursors.Hand;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(0, 192, 0);
            label9.Location = new Point(136, 40);
            label9.Name = "label9";
            label9.Size = new Size(88, 24);
            label9.TabIndex = 13;
            label9.Text = "Sing up";
            label9.Click += label9_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(62, 17);
            label8.Name = "label8";
            label8.Size = new Size(241, 23);
            label8.TabIndex = 2;
            label8.Text = "Don't have an account?";
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
            button1.Location = new Point(54, 374);
            button1.Name = "button1";
            button1.Size = new Size(362, 39);
            button1.TabIndex = 24;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ShowPassword2
            // 
            ShowPassword2.AutoSize = true;
            ShowPassword2.Cursor = Cursors.Hand;
            ShowPassword2.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowPassword2.Location = new Point(270, 307);
            ShowPassword2.Name = "ShowPassword2";
            ShowPassword2.Size = new Size(146, 23);
            ShowPassword2.TabIndex = 23;
            ShowPassword2.Text = "Show Password";
            ShowPassword2.UseVisualStyleBackColor = true;
            ShowPassword2.CheckedChanged += ShowPassword_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bookman Old Style", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(189, 57);
            label5.Name = "label5";
            label5.Size = new Size(89, 33);
            label5.TabIndex = 20;
            label5.Text = "Login";
            // 
            // PaaswordTextBox2
            // 
            PaaswordTextBox2.BorderStyle = BorderStyle.FixedSingle;
            PaaswordTextBox2.Cursor = Cursors.IBeam;
            PaaswordTextBox2.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PaaswordTextBox2.Location = new Point(54, 267);
            PaaswordTextBox2.Multiline = true;
            PaaswordTextBox2.Name = "PaaswordTextBox2";
            PaaswordTextBox2.PasswordChar = '*';
            PaaswordTextBox2.Size = new Size(362, 34);
            PaaswordTextBox2.TabIndex = 19;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(54, 178);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(362, 34);
            textBox1.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(445, 9);
            label4.Name = "label4";
            label4.Size = new Size(22, 21);
            label4.TabIndex = 16;
            label4.Text = "X";
            label4.Click += label4_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 241);
            label3.Name = "label3";
            label3.Size = new Size(102, 23);
            label3.TabIndex = 15;
            label3.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 152);
            label1.Name = "label1";
            label1.Size = new Size(161, 23);
            label1.TabIndex = 13;
            label1.Text = "Mobile or Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(141, 588);
            label2.Name = "label2";
            label2.Size = new Size(182, 23);
            label2.TabIndex = 26;
            label2.Text = "Forgot password?";
            label2.Click += label2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 485);
            label6.Name = "label6";
            label6.Size = new Size(165, 20);
            label6.TabIndex = 27;
            label6.Text = "--------------------------";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(251, 485);
            label7.Name = "label7";
            label7.Size = new Size(165, 20);
            label7.TabIndex = 28;
            label7.Text = "--------------------------";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(216, 485);
            label10.Name = "label10";
            label10.Size = new Size(36, 21);
            label10.TabIndex = 29;
            label10.Text = "OR";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 792);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(ShowPassword2);
            Controls.Add(label5);
            Controls.Add(PaaswordTextBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label9;
        private Label label8;
        private Button button1;
        private CheckBox ShowPassword2;
        private Label label5;
        private TextBox PaaswordTextBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label6;
        private Label label7;
        private Label label10;
    }
}