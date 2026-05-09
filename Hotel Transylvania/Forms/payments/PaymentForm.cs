using crud;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hotel_Transylvania.Forms.payments
{
    public partial class PaymentForm : Form
    {
        private int tierId;
        private int roomId;
        private decimal roomPrice = 0;
        private decimal totalAmount = 0;

        public PaymentForm(int selectedTierId)
        {
            InitializeComponent();
            tierId = selectedTierId;
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            dtpCheckIn.Value = DateTime.Today;
            dtpCheckOut.Value = DateTime.Today.AddDays(1);

            LoadRoomInfo();
            CalculateTotal();

            dtpCheckIn.ValueChanged += dtpCheckIn_ValueChanged;
            dtpCheckOut.ValueChanged += dtpCheckOut_ValueChanged;
            btnPayNow.Click += btnPayNow_Click;
        }

        private void LoadRoomInfo()
        {
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = @"
                    SELECT 
                        rooms.id,
                        rooms.room_number,
                        room_tiers.tier_name,
                        room_tiers.price,
                        room_tiers.capacity
                    FROM rooms
                    INNER JOIN room_tiers
                    ON rooms.room_tier_id = room_tiers.id
                    WHERE rooms.room_tier_id = @tierId
                    AND rooms.status = 'available'
                    LIMIT 1
                ";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@tierId", tierId);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    roomId = Convert.ToInt32(reader["id"]);

                    string tierName = reader["tier_name"].ToString();
                    string roomNumber = reader["room_number"].ToString();

                    roomPrice = Convert.ToDecimal(reader["price"]);

                    lblRoomType.Text = tierName + " Room";
                    lblRoomNumber.Text = roomNumber;
                    lblPrice.Text = "₱" + roomPrice.ToString("N2");
                    lblCapacity.Text = reader["capacity"].ToString();

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
                }
                else
                {
                    MessageBox.Show("No available room for this tier.");
                    this.Close();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading room: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void CalculateTotal()
        {
            int nights = (dtpCheckOut.Value.Date - dtpCheckIn.Value.Date).Days;

            if (nights <= 0)
            {
                nights = 1;
                dtpCheckOut.Value = dtpCheckIn.Value.AddDays(1);
            }

            totalAmount = roomPrice * nights;

            lblNight.Text = nights.ToString();
            lblTotalAmount.Text = "₱" + totalAmount.ToString("N2");
        }

        private void dtpCheckIn_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void dtpCheckOut_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "" || txtEmail.Text == "" || txtPhoneNumber.Text == "")
            {
                MessageBox.Show("Please fill out all guest information.");
                return;
            }

            SaveBookingAndPayment();
        }

        private void SaveBookingAndPayment()
        {
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                int customerId = Session.customerId;

                string bookingQuery = @"
                    INSERT INTO bookings
                    (customer_id, room_id, check_in, check_out, total_amount, status)
                    VALUES
                    (@customerId, @roomId, @checkIn, @checkOut, @totalAmount, 'approved')
                ";

                MySqlCommand bookingCmd = new MySqlCommand(bookingQuery, db.Connection);
                bookingCmd.Parameters.AddWithValue("@customerId", customerId);
                bookingCmd.Parameters.AddWithValue("@roomId", roomId);
                bookingCmd.Parameters.AddWithValue("@checkIn", dtpCheckIn.Value.Date);
                bookingCmd.Parameters.AddWithValue("@checkOut", dtpCheckOut.Value.Date);
                bookingCmd.Parameters.AddWithValue("@totalAmount", totalAmount);
                bookingCmd.ExecuteNonQuery();

                int bookingId = Convert.ToInt32(bookingCmd.LastInsertedId);

                string paymentQuery = @"
                    INSERT INTO payments
                    (booking_id, amount, payment_method, status)
                    VALUES
                    (@bookingId, @amount, 'Cash', 'paid')
                ";

                MySqlCommand paymentCmd = new MySqlCommand(paymentQuery, db.Connection);
                paymentCmd.Parameters.AddWithValue("@bookingId", bookingId);
                paymentCmd.Parameters.AddWithValue("@amount", totalAmount);
                paymentCmd.ExecuteNonQuery();

                string updateRoomQuery = @"
                    UPDATE rooms
                    SET status = 'occupied'
                    WHERE id = @roomId
                ";

                MySqlCommand updateRoomCmd = new MySqlCommand(updateRoomQuery, db.Connection);
                updateRoomCmd.Parameters.AddWithValue("@roomId", roomId);
                updateRoomCmd.ExecuteNonQuery();

                MessageBox.Show("Payment successful! Booking confirmed.");

                // Later: open SuccessForm and send email here
            }
            catch (Exception ex)
            {
                MessageBox.Show("Payment error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }
    }
}