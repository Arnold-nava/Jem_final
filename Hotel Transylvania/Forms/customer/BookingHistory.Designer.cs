namespace Hotel_Transylvania.Forms.customer
{
    partial class BookingHistory
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
            label2 = new Label();
            panel2 = new Panel();
            txtSearch = new TextBox();
            panel3 = new Panel();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            label6 = new Label();
            label5 = new Label();
            dgvBookings = new DataGridView();
            dtpDate = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
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
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 617);
            panel1.TabIndex = 2;
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
            btnBookings.BackColor = Color.Plum;
            btnBookings.FlatAppearance.BorderSize = 0;
            btnBookings.FlatStyle = FlatStyle.Flat;
            btnBookings.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBookings.ForeColor = Color.LavenderBlush;
            btnBookings.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            btnBookings.IconColor = Color.Black;
            btnBookings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBookings.ImageAlign = ContentAlignment.MiddleLeft;
            btnBookings.Location = new Point(13, 271);
            btnBookings.Name = "btnBookings";
            btnBookings.Size = new Size(191, 41);
            btnBookings.TabIndex = 1;
            btnBookings.Text = "Bookings";
            btnBookings.UseVisualStyleBackColor = false;
            btnBookings.Click += btnBookings_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Orchid;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(14, 15);
            label2.Name = "label2";
            label2.Size = new Size(163, 32);
            label2.TabIndex = 3;
            label2.Text = "My Bookings";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(dgvBookings);
            panel2.Controls.Add(dtpDate);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(235, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(664, 575);
            panel2.TabIndex = 4;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(22, 83);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Enter room number";
            txtSearch.Size = new Size(230, 27);
            txtSearch.TabIndex = 8;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Azure;
            panel3.Controls.Add(iconPictureBox2);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(19, 491);
            panel3.Name = "panel3";
            panel3.Size = new Size(627, 70);
            panel3.TabIndex = 7;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.Azure;
            iconPictureBox2.ForeColor = Color.PaleTurquoise;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Bell;
            iconPictureBox2.IconColor = Color.PaleTurquoise;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.Location = new Point(16, 21);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(32, 32);
            iconPictureBox2.TabIndex = 0;
            iconPictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(63, 39);
            label6.Name = "label6";
            label6.Size = new Size(375, 21);
            label6.TabIndex = 0;
            label6.Text = "Please arrive on time for your check-in. Thank you!";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(63, 9);
            label5.Name = "label5";
            label5.Size = new Size(107, 30);
            label5.TabIndex = 0;
            label5.Text = "Reminder";
            // 
            // dgvBookings
            // 
            dgvBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookings.Location = new Point(19, 119);
            dgvBookings.Name = "dgvBookings";
            dgvBookings.Size = new Size(627, 337);
            dgvBookings.TabIndex = 5;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(288, 83);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(148, 27);
            dtpDate.TabIndex = 4;
            dtpDate.ValueChanged += dtpDate_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(22, 59);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 3;
            label4.Text = "Search";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(288, 59);
            label3.Name = "label3";
            label3.Size = new Size(46, 21);
            label3.TabIndex = 3;
            label3.Text = "Date";
            // 
            // BookingHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(917, 619);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "BookingHistory";
            Text = "BookingHistory";
            Load += BookingHistory_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
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
        private Label label2;
        private Panel panel2;
        private DataGridView dgvBookings;
        private DateTimePicker dtpDate;
        private Label label3;
        private Panel panel3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Label label5;
        private Label label6;
        private TextBox txtSearch;
        private Label label4;
    }
}