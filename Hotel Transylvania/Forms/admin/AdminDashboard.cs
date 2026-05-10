using crud;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Hotel_Transylvania.Forms.admin
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardCounts();
            LoadRecentBookings();
        }

        private void LoadDashboardCounts()
        {
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                MySqlCommand totalRoomsCmd = new MySqlCommand("SELECT COUNT(*) FROM rooms", db.Connection);
                lblTotalRooms.Text = totalRoomsCmd.ExecuteScalar().ToString();

                MySqlCommand availableRoomsCmd = new MySqlCommand("SELECT COUNT(*) FROM rooms WHERE status='available'", db.Connection);
                lblAvailableRooms.Text = availableRoomsCmd.ExecuteScalar().ToString();

                MySqlCommand activeBookingsCmd = new MySqlCommand("SELECT COUNT(*) FROM bookings", db.Connection);
                lblActiveBookings.Text = activeBookingsCmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dashboard error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void LoadRecentBookings()
        {
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = @"
                    SELECT 
                        bookings.id AS 'Booking ID',
                        users.username AS 'Customer',
                        rooms.room_number AS 'Room No.',
                        room_tiers.tier_name AS 'Room Type',
                        bookings.check_in AS 'Check In',
                        bookings.check_out AS 'Check Out',
                        bookings.total_amount AS 'Total'
                    FROM bookings
                    INNER JOIN customers ON bookings.customer_id = customers.id
                    INNER JOIN users ON customers.user_id = users.id
                    INNER JOIN rooms ON bookings.room_id = rooms.id
                    INNER JOIN room_tiers ON rooms.room_tier_id = room_tiers.id
                    ORDER BY bookings.id DESC
                    LIMIT 5
                ";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.Connection);
                DataTable table = new DataTable();

                adapter.Fill(table);

                dgvRecentBookings.DataSource = table;

                dgvRecentBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvRecentBookings.AllowUserToAddRows = false;
                dgvRecentBookings.ReadOnly = true;
                dgvRecentBookings.RowHeadersVisible = false;
                dgvRecentBookings.BackgroundColor = Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Recent booking error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadDashboardCounts();
            LoadRecentBookings();
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            BookingManagement frm = new BookingManagement();
            frm.Show();
            this.Hide();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            RoomManagement frm = new RoomManagement();
            frm.Show();
            this.Hide();
        }

        private void btnRoomTier_Click(object sender, EventArgs e)
        {
            RoomTier frm = new RoomTier();
            frm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();

            LoginForm frm = new LoginForm();
            frm.Show();
            this.Hide();
        }

        private void btnViewAllBookings_Click(object sender, EventArgs e)
        {
            BookingManagement frm = new BookingManagement();
            frm.Show();
            this.Hide();
        }
    }
}