using crud;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Transylvania.Forms.customer
{
    public partial class CustomerDashboard : Form
    {
        public CustomerDashboard()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            CustomerDashboard frm = new CustomerDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            Room frm = new Room();
            frm.Show();
            this.Hide();
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            BookingHistory frm = new BookingHistory();
            frm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            lblCustomerName.Text = Session.FullName + "!";
            LoadCurrentBooking();
        }

        private void LoadCurrentBooking()
        {
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = @"
                    SELECT 
                        bookings.check_in,
                        bookings.check_out,
                        bookings.total_amount,
                        rooms.room_number,
                        room_tiers.tier_name
                    FROM bookings
                    INNER JOIN rooms ON bookings.room_id = rooms.id
                    INNER JOIN room_tiers ON rooms.room_tier_id = room_tiers.id
                    WHERE bookings.customer_id = @customerId
                    ORDER BY bookings.id DESC
                    LIMIT 1
                ";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@customerId", Session.customerId);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblRoom.Text = reader["tier_name"].ToString() + " " + reader["room_number"].ToString();
                    lblStatus.Text = "Booked";
                    lblCheckIn.Text = Convert.ToDateTime(reader["check_in"]).ToString("MMM dd, yyyy");
                    lblCheckOut.Text = Convert.ToDateTime(reader["check_out"]).ToString("MMM dd, yyyy");
                }
                else
                {
                    lblRoom.Text = "No booking yet";
                    lblStatus.Text = "None";
                    lblCheckIn.Text = "-";
                    lblCheckOut.Text = "-";
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading booking: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void btnViewBookings_Click(object sender, EventArgs e)
        {
            BookingHistory frm = new BookingHistory();
            frm.Show();
            this.Hide();
        }
    }
}
