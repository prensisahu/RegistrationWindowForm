using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace R_S
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=R_S;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            PaaswordRegistration.PasswordChar = ShowPassword.Checked ? '\0' : '*';
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Form2 form1 = new Form2();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = MobileorEmail.Text.Trim();
            string Fullname = FullnameRegistration.Text.Trim();
            string password = PaaswordRegistration.Text.Trim();

            // Check for empty username or password
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(Fullname))
            {
                MessageBox.Show("Please enter Full Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();

                    // Check if username exists
                    string selectemail = "SELECT COUNT(id) FROM users WHERE email = @email";

                    using (SqlCommand checkUser = new SqlCommand(selectemail, con))
                    {
                        checkUser.Parameters.AddWithValue("@email", email);
                        int count = (int)checkUser.ExecuteScalar();

                        if (count >= 1)
                        {
                            MessageBox.Show(email + " already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Insert new user
                    string insertData = "INSERT INTO users (Email, Fullname, password) VALUES (@Email, @Fullname, @password)";

                    using (SqlCommand cmd = new SqlCommand(insertData, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Fullname", Fullname);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Open login form and hide this form
                        Form2 loginForm = new Form2();
                        loginForm.Show();
                        this.Hide();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
