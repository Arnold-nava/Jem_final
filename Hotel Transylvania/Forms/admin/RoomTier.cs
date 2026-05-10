using crud;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hotel_Transylvania.Forms.admin
{
    public partial class RoomTier : Form
    {
        DBConnect db = new DBConnect();
        int selectedTierId = 0;

        public RoomTier()
        {
            InitializeComponent();
        }

        private void LoadTierCombo()
        {
            cmbRoomTier.Items.Clear();
            cmbRoomTier.Items.Add("Standard");
            cmbRoomTier.Items.Add("Deluxe");
            cmbRoomTier.Items.Add("Family");
            cmbRoomTier.Items.Add("Suite");
        }

        private void LoadRoomTiers()
        {
            try
            {
                db.Open();

                string query = @"
                    SELECT 
                        id AS 'ID',
                        tier_name AS 'Room Tier',
                        price AS 'Price',
                        capacity AS 'Capacity'
                    FROM room_tiers
                ";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.Connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvRoomTiers.DataSource = table;

                dgvRoomTiers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvRoomTiers.AllowUserToAddRows = false;
                dgvRoomTiers.ReadOnly = true;
                dgvRoomTiers.RowHeadersVisible = false;

                dgvRoomTiers.Columns["ID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load room tiers error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void dgvRoomTiers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedTierId = Convert.ToInt32(dgvRoomTiers.Rows[e.RowIndex].Cells["ID"].Value);
                cmbRoomTier.Text = dgvRoomTiers.Rows[e.RowIndex].Cells["Room Tier"].Value.ToString();
                txtPrice.Text = dgvRoomTiers.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                txtCapacity.Text = dgvRoomTiers.Rows[e.RowIndex].Cells["Capacity"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedTierId == 0)
            {
                MessageBox.Show("Please select a room tier first.");
                return;
            }

            if (cmbRoomTier.Text == "" || txtPrice.Text == "" || txtCapacity.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                db.Open();

                string query = @"
                    UPDATE room_tiers
                    SET tier_name=@tierName,
                        price=@price,
                        capacity=@capacity
                    WHERE id=@id
                ";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@tierName", cmbRoomTier.Text);
                cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                cmd.Parameters.AddWithValue("@capacity", txtCapacity.Text);
                cmd.Parameters.AddWithValue("@id", selectedTierId);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Room tier updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error: " + ex.Message);
            }
            finally
            {
                db.Close();
                LoadRoomTiers();
                ClearFields();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedTierId == 0)
            {
                MessageBox.Show("Please select a room tier first.");
                return;
            }

            try
            {
                db.Open();

                string query = "DELETE FROM room_tiers WHERE id=@id";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@id", selectedTierId);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Room tier deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete error: " + ex.Message);
            }
            finally
            {
                db.Close();
                LoadRoomTiers();
                ClearFields();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            selectedTierId = 0;
            cmbRoomTier.SelectedIndex = -1;
            txtPrice.Clear();
            txtCapacity.Clear();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AdminDashboard frm = new AdminDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnBooking_Click(object sender, EventArgs e)
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
            LoadRoomTiers();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();

            LoginForm frm = new LoginForm();
            frm.Show();
            this.Hide();
        }

        private void RoomTier_Load_1(object sender, EventArgs e)
        {
            LoadTierCombo();
            LoadRoomTiers();
        }
    }
}