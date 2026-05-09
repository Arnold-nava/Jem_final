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

                string checkQuery = "SELECT COUNT(*) FROM users WHERE username=@username OR email=@email";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, db.Connection);
                checkCmd.Parameters.AddWithValue("@username", username);
                checkCmd.Parameters.AddWithValue("@email", email);

                int existing = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (existing > 0)
                {
                    MessageBox.Show("Username or email already exists.");
                    return;
                }

                string userQuery = @"
                    INSERT INTO users
                    (full_name, username, email, password, role)
                    VALUES
                    (@fullName, @username, @email, @password, 'customer')
                ";

                MySqlCommand userCmd = new MySqlCommand(userQuery, db.Connection);
                userCmd.Parameters.AddWithValue("@fullName", fullName);
                userCmd.Parameters.AddWithValue("@username", username);
                userCmd.Parameters.AddWithValue("@email", email);
                userCmd.Parameters.AddWithValue("@password", password);
                userCmd.ExecuteNonQuery();

                int userId = Convert.ToInt32(userCmd.LastInsertedId);

                string customerQuery = @"
                    INSERT INTO customers
                    (user_id, contact_number, address)
                    VALUES
                    (@userId, @phone, '')
                ";

                MySqlCommand customerCmd = new MySqlCommand(customerQuery, db.Connection);
                customerCmd.Parameters.AddWithValue("@userId", userId);
                customerCmd.Parameters.AddWithValue("@phone", phone);
                customerCmd.ExecuteNonQuery();

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

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}