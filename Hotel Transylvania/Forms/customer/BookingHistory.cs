using crud;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hotel_Transylvania.Forms.customer
{
    public partial class BookingHistory : Form
    {
        public BookingHistory()
        {
            InitializeComponent();
        }

        private void LoadBookings()
        {
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = @"
                    SELECT 
                        bookings.id AS 'Booking ID',
                        rooms.room_number AS 'Room Number',
                        room_tiers.tier_name AS 'Room Type',
                        bookings.check_in AS 'Check In',
                        bookings.check_out AS 'Check Out',
                        bookings.total_amount AS 'Total Amount',
                        bookings.created_at AS 'Booked On'
                    FROM bookings
                    INNER JOIN rooms ON bookings.room_id = rooms.id
                    INNER JOIN room_tiers ON rooms.room_tier_id = room_tiers.id
                    WHERE bookings.customer_id = @customerId
                    ORDER BY bookings.id DESC
                ";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@customerId", Session.customerId);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();

                adapter.Fill(table);

                dgvBookings.DataSource = table;

                dgvBookings.AllowUserToAddRows = false;
                dgvBookings.ReadOnly = true;

                dgvBookings.BackgroundColor = Color.White;
                dgvBookings.BorderStyle = BorderStyle.None;

                dgvBookings.RowHeadersVisible = false;

                dgvBookings.EnableHeadersVisualStyles = false;

                dgvBookings.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                dgvBookings.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

                dgvBookings.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 230, 230);
                dgvBookings.DefaultCellStyle.SelectionForeColor = Color.Black;

                dgvBookings.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bookings: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void FilterByDate()
        {
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = @"
            SELECT 
                bookings.id AS 'Booking ID',
                rooms.room_number AS 'Room Number',
                room_tiers.tier_name AS 'Room Type',
                bookings.check_in AS 'Check In',
                bookings.check_out AS 'Check Out',
                bookings.total_amount AS 'Total Amount',
                bookings.created_at AS 'Booked On'

            FROM bookings

            INNER JOIN rooms 
            ON bookings.room_id = rooms.id

            INNER JOIN room_tiers 
            ON rooms.room_tier_id = room_tiers.id

            WHERE bookings.customer_id = @customerId
            AND bookings.check_in = @date

            ORDER BY bookings.id DESC
        ";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@customerId", Session.customerId);
                cmd.Parameters.AddWithValue("@date", dtpDate.Value.Date);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();

                adapter.Fill(table);

                dgvBookings.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Date filter error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void SearchBookings()
        {
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = @"
                    SELECT 
                        bookings.id AS 'Booking ID',
                        rooms.room_number AS 'Room Number',
                        room_tiers.tier_name AS 'Room Type',
                        bookings.check_in AS 'Check In',
                        bookings.check_out AS 'Check Out',
                        bookings.total_amount AS 'Total Amount',
                        bookings.created_at AS 'Booked On'
                    FROM bookings
                    INNER JOIN rooms ON bookings.room_id = rooms.id
                    INNER JOIN room_tiers ON rooms.room_tier_id = room_tiers.id
                    WHERE bookings.customer_id = @customerId
                    AND rooms.room_number LIKE @search
                    ORDER BY bookings.id DESC
                ";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@customerId", Session.customerId);
                cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();

                adapter.Fill(table);

                dgvBookings.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
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
            LoadBookings();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();

            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void BookingHistory_Load(object sender, EventArgs e)
        {
            LoadBookings();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchBookings();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            FilterByDate();
        }
    }
}