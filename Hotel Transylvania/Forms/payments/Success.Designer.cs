namespace Hotel_Transylvania.Forms.payments
{
    partial class Success
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            label2 = new Label();
            lblBookingId = new Label();
            btnViewBookings = new Button();
            btnBackHome = new Button();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.MistyRose;
            iconPictureBox1.ForeColor = Color.Lime;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            iconPictureBox1.IconColor = Color.Lime;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 167;
            iconPictureBox1.Location = new Point(168, 35);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(200, 167);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(91, 218);
            label1.Name = "label1";
            label1.Size = new Size(354, 47);
            label1.TabIndex = 1;
            label1.Text = "Payment Successful!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(126, 265);
            label2.Name = "label2";
            label2.Size = new Size(277, 21);
            label2.TabIndex = 2;
            label2.Text = "Your Booking Has Been Confirmed!";
            // 
            // lblBookingId
            // 
            lblBookingId.AutoSize = true;
            lblBookingId.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookingId.Location = new Point(91, 313);
            lblBookingId.Name = "lblBookingId";
            lblBookingId.Size = new Size(364, 47);
            lblBookingId.TabIndex = 1;
            lblBookingId.Text = "Booking ID: #000000";
            // 
            // btnViewBookings
            // 
            btnViewBookings.AutoSize = true;
            btnViewBookings.BackColor = Color.Pink;
            btnViewBookings.FlatStyle = FlatStyle.Flat;
            btnViewBookings.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewBookings.Location = new Point(105, 375);
            btnViewBookings.Name = "btnViewBookings";
            btnViewBookings.Size = new Size(330, 64);
            btnViewBookings.TabIndex = 3;
            btnViewBookings.Text = "View my Bookings";
            btnViewBookings.UseVisualStyleBackColor = false;
            btnViewBookings.Click += btnViewBookings_Click;
            // 
            // btnBackHome
            // 
            btnBackHome.AutoSize = true;
            btnBackHome.BackColor = SystemColors.ButtonHighlight;
            btnBackHome.FlatStyle = FlatStyle.Flat;
            btnBackHome.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackHome.Location = new Point(105, 456);
            btnBackHome.Name = "btnBackHome";
            btnBackHome.Size = new Size(330, 64);
            btnBackHome.TabIndex = 3;
            btnBackHome.Text = "Back home";
            btnBackHome.UseVisualStyleBackColor = false;
            btnBackHome.Click += btnBackHome_Click;
            // 
            // Success
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(551, 607);
            Controls.Add(btnBackHome);
            Controls.Add(btnViewBookings);
            Controls.Add(label2);
            Controls.Add(lblBookingId);
            Controls.Add(label1);
            Controls.Add(iconPictureBox1);
            Name = "Success";
            Text = "Success";
            Load += Success_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label1;
        private Label label2;
        private Label lblBookingId;
        private Button btnViewBookings;
        private Button btnBackHome;
    }
}