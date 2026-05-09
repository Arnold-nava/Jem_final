using crud;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Hotel_Transylvania.Forms.auth
{
    public partial class Register : Form
    {
        DBConnect db = new DBConnect();

        public Register()
        {
            InitializeComponent();
        }


        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();

            if (fullName == "" || username == "" || password == "" || email == "")
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            try
            {
                db.Open();

                string checkQuery = "SELECT COUNT(*) FROM users WHERE username = @username OR email = @email";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, db.Connection);
                checkCmd.Parameters.AddWithValue("@username", username);
                checkCmd.Parameters.AddWithValue("@email", email);

                int existing = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (existing > 0)
                {
                    MessageBox.Show("Username or email already exists.");
                    return;
                }

                string query = @"INSERT INTO users 
                                (full_name, username, password, email, phone, role) 
                                VALUES 
                                (@fullName, @username, @password, @email, @phone, 'customer')";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@fullName", fullName);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@phone", phone);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Account created successfully!");

                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Register error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }
    }
}