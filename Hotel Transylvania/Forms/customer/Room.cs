using crud;
using Hotel_Transylvania.Forms.payments;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hotel_Transylvania.Forms.customer
{
    public partial class Room : Form
    {
        public Room()
        {
            InitializeComponent();
        }

        private void Room_Load(object sender, EventArgs e)
        {
            LoadRoomCards();
        }

        private void LoadRoomCards()
        {
            flowRooms.Controls.Clear();

            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = @"
                    SELECT 
                        room_tiers.id,
                        room_tiers.tier_name,
                        room_tiers.price,
                        room_tiers.capacity,
                        COUNT(rooms.id) AS available_count

                    FROM room_tiers

                    LEFT JOIN rooms
                    ON room_tiers.id = rooms.room_tier_id
                    AND rooms.status = 'available'

                    GROUP BY room_tiers.id
                ";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int tierId = Convert.ToInt32(reader["id"]);
                    string tierName = reader["tier_name"].ToString();
                    decimal price = Convert.ToDecimal(reader["price"]);
                    string capacity = reader["capacity"].ToString();
                    int available = Convert.ToInt32(reader["available_count"]);

                    Panel card = new Panel();
                    card.Width = 240;
                    card.Height = 280;
                    card.BackColor = Color.White;
                    card.BorderStyle = BorderStyle.FixedSingle;
                    card.Margin = new Padding(10);

                    PictureBox picRoom = new PictureBox();
                    picRoom.Width = 238;
                    picRoom.Height = 100;
                    picRoom.Location = new Point(0, 0);
                    picRoom.SizeMode = PictureBoxSizeMode.StretchImage;

                    if (tierName == "Standard")
                    {
                        picRoom.Image = Properties.Resources.standard;
                    }
                    else if (tierName == "Deluxe")
                    {
                        picRoom.Image = Properties.Resources.Deluxe;
                    }
                    else if (tierName == "Family")
                    {
                        picRoom.Image = Properties.Resources.Family;
                    }
                    else if (tierName == "Suite")
                    {
                        picRoom.Image = Properties.Resources.Suite;
                    }

                    Label lblTier = new Label();
                    lblTier.Text = tierName + " Room";
                    lblTier.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    lblTier.Location = new Point(15, 115);
                    lblTier.AutoSize = true;

                    Label lblPrice = new Label();
                    lblPrice.Text = "₱" + price.ToString("N2") + " / night";
                    lblPrice.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    lblPrice.Location = new Point(15, 145);
                    lblPrice.AutoSize = true;

                    Label lblCapacity = new Label();
                    lblCapacity.Text = "Capacity: " + capacity;
                    lblCapacity.Location = new Point(15, 175);
                    lblCapacity.AutoSize = true;

                    Label lblAvailable = new Label();
                    lblAvailable.Location = new Point(15, 210);
                    lblAvailable.AutoSize = true;

                    Button btnBook = new Button();
                    btnBook.Text = "BOOK NOW";
                    btnBook.Width = 100;
                    btnBook.Height = 35;
                    btnBook.Location = new Point(125, 235);
                    btnBook.BackColor = Color.FromArgb(90, 20, 80);
                    btnBook.ForeColor = Color.White;
                    btnBook.FlatStyle = FlatStyle.Flat;
                    btnBook.Tag = tierId;

                    if (available > 0)
                    {
                        lblAvailable.Text = available + " Rooms Available";
                        lblAvailable.ForeColor = Color.Green;
                        btnBook.Enabled = true;
                    }
                    else
                    {
                        lblAvailable.Text = "No Rooms Available";
                        lblAvailable.ForeColor = Color.Red;
                        btnBook.Enabled = false;
                    }

                    btnBook.Click += BtnBook_Click;

                    card.Controls.Add(picRoom);
                    card.Controls.Add(lblTier);
                    card.Controls.Add(lblPrice);
                    card.Controls.Add(lblCapacity);
                    card.Controls.Add(lblAvailable);
                    card.Controls.Add(btnBook);

                    flowRooms.Controls.Add(card);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rooms: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void BtnBook_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int tierId = Convert.ToInt32(btn.Tag);

            PaymentForm frm = new PaymentForm(tierId);
            frm.Show();
            this.Hide();
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
    }
}