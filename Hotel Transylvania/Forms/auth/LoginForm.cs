using crud;
using MySql.Data.MySqlClient;
using Hotel_Transylvania.Forms.auth;
using Hotel_Transylvania.Forms.admin;
using Hotel_Transylvania.Forms.customer;
using System;
using System.Windows.Forms;

namespace Hotel_Transylvania
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLoggin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = "SELECT * FROM users WHERE username=@username AND password=@password";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Session.userId = Convert.ToInt32(reader["id"]);
                    Session.username = reader["username"].ToString();
                    Session.role = reader["role"].ToString();

                    reader.Close();

                    if (Session.role == "customer")
                    {
                        string customerQuery = "SELECT id FROM customers WHERE user_id=@userId";

                        MySqlCommand customerCmd = new MySqlCommand(customerQuery, db.Connection);
                        customerCmd.Parameters.AddWithValue("@userId", Session.userId);

                        object result = customerCmd.ExecuteScalar();

                        if (result != null)
                        {
                            Session.customerId = Convert.ToInt32(result);

                            CustomerDashboard frm = new CustomerDashboard();
                            frm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Customer profile not found.");
                        }
                    }
                    else if (Session.role == "admin")
                    {
                        AdminDashboard frm = new AdminDashboard();
                        frm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register frm = new Register();
            frm.Show();
            this.Hide();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}