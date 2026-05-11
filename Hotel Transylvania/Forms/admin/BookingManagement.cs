using crud;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hotel_Transylvania.Forms.admin
{
    public partial class BookingManagement : Form
    {
        DBConnect db = new DBConnect();

        int selectedBookingId = 0;
        int selectedRoomId = 0;

        public BookingManagement()
        {
            InitializeComponent();
        }

        private void BookingManagement_Load(object sender, EventArgs e)
        {
            LoadBookings();
        }

        private void LoadBookings()
        {
            try
            {
                db.Open();

                string query = @"
                    SELECT
                        bookings.id AS 'Booking ID',
                        rooms.id AS 'Room ID',
                        users.username AS 'Customer',
                        rooms.room_number AS 'Room Number',
                        room_tiers.tier_name AS 'Room Type',
                        bookings.check_in AS 'Check In',
                        bookings.check_out AS 'Check Out',
                        bookings.total_amount AS 'Total Amount'
                    FROM bookings
                    INNER JOIN customers ON bookings.customer_id = customers.id
                    INNER JOIN users ON customers.user_id = users.id
                    INNER JOIN rooms ON bookings.room_id = rooms.id
                    INNER JOIN room_tiers ON rooms.room_tier_id = room_tiers.id
                    ORDER BY bookings.id DESC
                ";

                MySqlDataAdapter adapter =
                    new MySqlDataAdapter(query, db.Connection);

                DataTable table = new DataTable();

                adapter.Fill(table);

                dgvBookings.DataSource = table;

                dgvBookings.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvBookings.AllowUserToAddRows = false;
                dgvBookings.ReadOnly = true;
                dgvBookings.RowHeadersVisible = false;

                dgvBookings.Columns["Room ID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading bookings: " + ex.Message
                );
            }
            finally
            {
                db.Close();
            }
        }

        private void SearchBookings()
        {
            try
            {
                db.Open();

                string query = @"
                    SELECT
                        bookings.id AS 'Booking ID',
                        rooms.id AS 'Room ID',
                        users.username AS 'Customer',
                        rooms.room_number AS 'Room Number',
                        room_tiers.tier_name AS 'Room Type',
                        bookings.check_in AS 'Check In',
                        bookings.check_out AS 'Check Out',
                        bookings.total_amount AS 'Total Amount'
                    FROM bookings
                    INNER JOIN customers ON bookings.customer_id = customers.id
                    INNER JOIN users ON customers.user_id = users.id
                    INNER JOIN rooms ON bookings.room_id = rooms.id
                    INNER JOIN room_tiers ON rooms.room_tier_id = room_tiers.id
                    WHERE users.username LIKE @search
                    OR rooms.room_number LIKE @search
                    ORDER BY bookings.id DESC
                ";

                MySqlCommand cmd =
                    new MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue(
                    "@search",
                    "%" + txtSearch.Text + "%"
                );

                MySqlDataAdapter adapter =
                    new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();

                adapter.Fill(table);

                dgvBookings.DataSource = table;

                dgvBookings.Columns["Room ID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Search error: " + ex.Message
                );
            }
            finally
            {
                db.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void ClearFields()
        {
            selectedBookingId = 0;
            selectedRoomId = 0;

            cmbRoom.Text = "";
            txtSearch.Clear();
        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AdminDashboard frm = new AdminDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            LoadBookings();
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

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (selectedBookingId == 0)
            {
                MessageBox.Show(
                    "Please select a booking first."
                );
                return;
            }

            try
            {
                db.Open();

                string deleteQuery =
                    "DELETE FROM bookings WHERE id=@id";

                MySqlCommand deleteCmd =
                    new MySqlCommand(deleteQuery, db.Connection);

                deleteCmd.Parameters.AddWithValue(
                    "@id",
                    selectedBookingId
                );

                deleteCmd.ExecuteNonQuery();

                string updateRoomQuery = @"
                    UPDATE rooms
                    SET status='available'
                    WHERE id=@roomId
                ";

                MySqlCommand updateCmd =
                    new MySqlCommand(updateRoomQuery, db.Connection);

                updateCmd.Parameters.AddWithValue(
                    "@roomId",
                    selectedRoomId
                );

                updateCmd.ExecuteNonQuery();

                MessageBox.Show("Booking deleted.");

                LoadBookings();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Delete error: " + ex.Message
                );
            }
            finally
            {
                db.Close();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchBookings();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            LoadBookings();
        }

        private void dgvBookings_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedBookingId =
                    Convert.ToInt32(
                        dgvBookings.Rows[e.RowIndex]
                        .Cells["Booking ID"].Value
                    );

                selectedRoomId =
                    Convert.ToInt32(
                        dgvBookings.Rows[e.RowIndex]
                        .Cells["Room ID"].Value
                    );

                cmbRoom.Text =
                    dgvBookings.Rows[e.RowIndex]
                    .Cells["Room Number"].Value.ToString();
            }
        }
    }
}