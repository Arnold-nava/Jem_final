using crud;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hotel_Transylvania.Forms.admin
{
    public partial class RoomManagement : Form
    {
        DBConnect db = new DBConnect();
        int selectedRoomId = 0;

        public RoomManagement()
        {
            InitializeComponent();
        }

        private void RoomManagement_Load(object sender, EventArgs e)
        {
            LoadRoomTiers();
            LoadStatus();
            LoadRooms();
        }

        private void LoadRoomTiers()
        {
            cmbRoomTier.Items.Clear();

            try
            {
                db.Open();

                string query = "SELECT id, tier_name FROM room_tiers";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbRoomTier.Items.Add(
                        reader["id"].ToString() + " - " + reader["tier_name"].ToString()
                    );
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load tiers error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void LoadStatus()
        {
            cmbStatus.Items.Clear();

            cmbStatus.Items.Add("available");
            cmbStatus.Items.Add("occupied");
            cmbStatus.Items.Add("maintenance");
        }

        private void LoadRooms()
        {
            try
            {
                db.Open();

                string query = @"
                    SELECT
                        rooms.id AS 'Room ID',
                        rooms.room_number AS 'Room Number',
                        room_tiers.tier_name AS 'Room Tier',
                        rooms.status AS 'Status'
                    FROM rooms
                    INNER JOIN room_tiers
                    ON rooms.room_tier_id = room_tiers.id
                    ORDER BY rooms.room_number ASC
                ";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.Connection);
                DataTable table = new DataTable();

                adapter.Fill(table);

                dgvRooms.DataSource = table;

                dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvRooms.AllowUserToAddRows = false;
                dgvRooms.ReadOnly = true;
                dgvRooms.RowHeadersVisible = false;

                dgvRooms.Columns["Room ID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load rooms error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private int GetIdFromCombo(string text)
        {
            string[] parts = text.Split('-');
            return Convert.ToInt32(parts[0].Trim());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtRoomNumber.Text == "" || cmbRoomTier.Text == "" || cmbStatus.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            int tierId = GetIdFromCombo(cmbRoomTier.Text);

            try
            {
                db.Open();

                string query = @"
                    INSERT INTO rooms
                    (room_number, room_tier_id, status)
                    VALUES
                    (@roomNumber, @tierId, @status)
                ";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@roomNumber", txtRoomNumber.Text);
                cmd.Parameters.AddWithValue("@tierId", tierId);
                cmd.Parameters.AddWithValue("@status", cmbStatus.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Room added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add room error: " + ex.Message);
            }
            finally
            {
                db.Close();
                LoadRooms();
                ClearFields();
            }
        }

        private void dgvRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRoomId = Convert.ToInt32(
                    dgvRooms.Rows[e.RowIndex].Cells["Room ID"].Value
                );

                txtRoomNumber.Text =
                    dgvRooms.Rows[e.RowIndex].Cells["Room Number"].Value.ToString();

                cmbStatus.Text =
                    dgvRooms.Rows[e.RowIndex].Cells["Status"].Value.ToString();

                string tierName =
                    dgvRooms.Rows[e.RowIndex].Cells["Room Tier"].Value.ToString();

                for (int i = 0; i < cmbRoomTier.Items.Count; i++)
                {
                    if (cmbRoomTier.Items[i].ToString().Contains(tierName))
                    {
                        cmbRoomTier.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedRoomId == 0)
            {
                MessageBox.Show("Please select a room first.");
                return;
            }

            if (txtRoomNumber.Text == "" || cmbRoomTier.Text == "" || cmbStatus.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            int tierId = GetIdFromCombo(cmbRoomTier.Text);

            try
            {
                db.Open();

                string query = @"
                    UPDATE rooms
                    SET room_number=@roomNumber,
                        room_tier_id=@tierId,
                        status=@status
                    WHERE id=@id
                ";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@roomNumber", txtRoomNumber.Text);
                cmd.Parameters.AddWithValue("@tierId", tierId);
                cmd.Parameters.AddWithValue("@status", cmbStatus.Text);
                cmd.Parameters.AddWithValue("@id", selectedRoomId);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Room updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update room error: " + ex.Message);
            }
            finally
            {
                db.Close();
                LoadRooms();
                ClearFields();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRoomId == 0)
            {
                MessageBox.Show("Please select a room first.");
                return;
            }

            try
            {
                db.Open();

                string query = "DELETE FROM rooms WHERE id=@id";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@id", selectedRoomId);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Room deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete room error: " + ex.Message);
            }
            finally
            {
                db.Close();
                LoadRooms();
                ClearFields();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            selectedRoomId = 0;

            txtRoomNumber.Clear();
            cmbRoomTier.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AdminDashboard frm = new AdminDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            BookingManagement frm = new BookingManagement();
            frm.Show();
            this.Hide();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            LoadRooms();
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
    }
}