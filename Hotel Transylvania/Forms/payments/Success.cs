using Hotel_Transylvania.Forms.customer;
using System;
using System.Windows.Forms;

namespace Hotel_Transylvania.Forms.payments
{
    public partial class Success : Form
    {
        private int bookingId;

        public Success(int newBookingId)
        {
            InitializeComponent();
            bookingId = newBookingId;
        }

        private void Success_Load(object sender, EventArgs e)
        {
            lblBookingId.Text = "Booking ID: #" + bookingId.ToString("000000");
        }

        private void btnViewBookings_Click(object sender, EventArgs e)
        {
            BookingHistory frm = new BookingHistory();
            frm.Show();
            this.Hide();
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            CustomerDashboard frm = new CustomerDashboard();
            frm.Show();
            this.Hide();
        }
    }
}