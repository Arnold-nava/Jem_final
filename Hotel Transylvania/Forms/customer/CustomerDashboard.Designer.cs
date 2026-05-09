namespace Hotel_Transylvania.Forms.customer
{
    partial class CustomerDashboard
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
            panel1 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            btnLogout = new FontAwesome.Sharp.IconButton();
            btnBookNow = new FontAwesome.Sharp.IconButton();
            btnBookings = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            panel2 = new Panel();
            lblCustomerName = new Label();
            label2 = new Label();
            panel3 = new Panel();
            btnViewBookings = new Button();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            lblCheckOut = new Label();
            label8 = new Label();
            lblCheckIn = new Label();
            label7 = new Label();
            lblStatus = new Label();
            label6 = new Label();
            lblRoom = new Label();
            label5 = new Label();
            label4 = new Label();
            panel4 = new Panel();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            label14 = new Label();
            label13 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orchid;
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnBookNow);
            panel1.Controls.Add(btnBookings);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 617);
            panel1.TabIndex = 1;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Orchid;
            iconPictureBox1.ForeColor = Color.LavenderBlush;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Hotel;
            iconPictureBox1.IconColor = Color.LavenderBlush;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 74;
            iconPictureBox1.Location = new Point(64, 11);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(82, 74);
            iconPictureBox1.TabIndex = 2;
            iconPictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.LavenderBlush;
            btnLogout.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btnLogout.IconColor = Color.Black;
            btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(11, 563);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(191, 41);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnBookNow
            // 
            btnBookNow.FlatAppearance.BorderSize = 0;
            btnBookNow.FlatStyle = FlatStyle.Flat;
            btnBookNow.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBookNow.ForeColor = Color.LavenderBlush;
            btnBookNow.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            btnBookNow.IconColor = Color.Black;
            btnBookNow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBookNow.ImageAlign = ContentAlignment.MiddleLeft;
            btnBookNow.Location = new Point(11, 212);
            btnBookNow.Name = "btnBookNow";
            btnBookNow.Size = new Size(191, 41);
            btnBookNow.TabIndex = 1;
            btnBookNow.Text = "Book now!";
            btnBookNow.UseVisualStyleBackColor = true;
            btnBookNow.Click += btnBookNow_Click;
            // 
            // btnBookings
            // 
            btnBookings.FlatAppearance.BorderSize = 0;
            btnBookings.FlatStyle = FlatStyle.Flat;
            btnBookings.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBookings.ForeColor = Color.LavenderBlush;
            btnBookings.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            btnBookings.IconColor = Color.Black;
            btnBookings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBookings.ImageAlign = ContentAlignment.MiddleLeft;
            btnBookings.Location = new Point(13, 272);
            btnBookings.Name = "btnBookings";
            btnBookings.Size = new Size(191, 41);
            btnBookings.TabIndex = 1;
            btnBookings.Text = "Bookings";
            btnBookings.UseVisualStyleBackColor = true;
            btnBookings.Click += btnBookings_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Plum;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.LavenderBlush;
            btnDashboard.IconChar = FontAwesome.Sharp.IconChar.House;
            btnDashboard.IconColor = Color.Black;
            btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(11, 154);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(191, 41);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LavenderBlush;
            label1.Location = new Point(11, 88);
            label1.Name = "label1";
            label1.Size = new Size(193, 30);
            label1.TabIndex = 0;
            label1.Text = "Hotel Transylvania";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblCustomerName);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(251, 17);
            panel2.Name = "panel2";
            panel2.Size = new Size(530, 69);
            panel2.TabIndex = 2;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerName.Location = new Point(14, 30);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(82, 30);
            lblCustomerName.TabIndex = 0;
            lblCustomerName.Text = "Guest !";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 10);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 0;
            label2.Text = "Welcome back!";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btnViewBookings);
            panel3.Controls.Add(iconPictureBox2);
            panel3.Controls.Add(lblCheckOut);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(lblCheckIn);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(lblStatus);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(lblRoom);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(251, 106);
            panel3.Name = "panel3";
            panel3.Size = new Size(530, 265);
            panel3.TabIndex = 2;
            // 
            // btnViewBookings
            // 
            btnViewBookings.BackColor = Color.Crimson;
            btnViewBookings.FlatAppearance.BorderSize = 0;
            btnViewBookings.FlatStyle = FlatStyle.Flat;
            btnViewBookings.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewBookings.ForeColor = SystemColors.ButtonHighlight;
            btnViewBookings.Location = new Point(196, 187);
            btnViewBookings.Name = "btnViewBookings";
            btnViewBookings.Size = new Size(234, 41);
            btnViewBookings.TabIndex = 2;
            btnViewBookings.Text = "View my bookings";
            btnViewBookings.UseVisualStyleBackColor = false;
            btnViewBookings.Click += btnViewBookings_Click;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.White;
            iconPictureBox2.ForeColor = Color.DeepPink;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            iconPictureBox2.IconColor = Color.DeepPink;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 75;
            iconPictureBox2.Location = new Point(31, 49);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(79, 75);
            iconPictureBox2.TabIndex = 1;
            iconPictureBox2.TabStop = false;
            // 
            // lblCheckOut
            // 
            lblCheckOut.AutoSize = true;
            lblCheckOut.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCheckOut.Location = new Point(348, 151);
            lblCheckOut.Name = "lblCheckOut";
            lblCheckOut.Size = new Size(80, 20);
            lblCheckOut.TabIndex = 0;
            lblCheckOut.Text = "Check Out";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(196, 151);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 0;
            label8.Text = "Check Out";
            // 
            // lblCheckIn
            // 
            lblCheckIn.AutoSize = true;
            lblCheckIn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCheckIn.Location = new Point(348, 119);
            lblCheckIn.Name = "lblCheckIn";
            lblCheckIn.Size = new Size(68, 20);
            lblCheckIn.TabIndex = 0;
            lblCheckIn.Text = "Check In";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(196, 119);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 0;
            label7.Text = "Check In";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(348, 82);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(53, 20);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(196, 82);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 0;
            label6.Text = "Status";
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoom.Location = new Point(348, 49);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(51, 20);
            lblRoom.TabIndex = 0;
            lblRoom.Text = "Room";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(196, 49);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 0;
            label5.Text = "Room";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(14, 11);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 0;
            label4.Text = "Current Booking";
            // 
            // panel4
            // 
            panel4.BackColor = Color.MintCream;
            panel4.Controls.Add(iconPictureBox3);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label13);
            panel4.Location = new Point(251, 404);
            panel4.Name = "panel4";
            panel4.Size = new Size(530, 170);
            panel4.TabIndex = 2;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.MintCream;
            iconPictureBox3.ForeColor = Color.DeepSkyBlue;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.BellConcierge;
            iconPictureBox3.IconColor = Color.DeepSkyBlue;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 80;
            iconPictureBox3.Location = new Point(430, 34);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(80, 85);
            iconPictureBox3.TabIndex = 1;
            iconPictureBox3.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.DeepSkyBlue;
            label14.Location = new Point(14, 89);
            label14.Name = "label14";
            label14.Size = new Size(280, 30);
            label14.TabIndex = 0;
            label14.Text = "We are happy to serve you.";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.DeepSkyBlue;
            label13.Location = new Point(14, 22);
            label13.Name = "label13";
            label13.Size = new Size(177, 30);
            label13.TabIndex = 0;
            label13.Text = "Have a nice stay!";
            // 
            // CustomerDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(800, 618);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CustomerDashboard";
            Text = "CustomerDashboard";
            Load += CustomerDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnBookNow;
        private FontAwesome.Sharp.IconButton btnBookings;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private Label label1;
        private Panel panel2;
        private Label lblCustomerName;
        private Label label2;
        private Panel panel3;
        private Panel panel4;
        private Button btnViewBookings;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Label lblCheckOut;
        private Label label8;
        private Label lblCheckIn;
        private Label label7;
        private Label lblStatus;
        private Label label6;
        private Label lblRoom;
        private Label label5;
        private Label label4;
        private Label label14;
        private Label label13;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
    }
}