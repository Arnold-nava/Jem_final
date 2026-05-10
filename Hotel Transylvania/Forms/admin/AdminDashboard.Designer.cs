namespace Hotel_Transylvania.Forms.admin
{
    partial class AdminDashboard
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
            btnLogout = new FontAwesome.Sharp.IconButton();
            btnRoomTier = new FontAwesome.Sharp.IconButton();
            btnRooms = new FontAwesome.Sharp.IconButton();
            btnBookings = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            lblTotalRooms = new Label();
            label5 = new Label();
            panel4 = new Panel();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            lblAvailableRooms = new Label();
            label8 = new Label();
            panel5 = new Panel();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            lblActiveBookings = new Label();
            label10 = new Label();
            panel6 = new Panel();
            btnViewAllBookings = new Button();
            dgvRecentBookings = new DataGridView();
            label11 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentBookings).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCoral;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnRoomTier);
            panel1.Controls.Add(btnRooms);
            panel1.Controls.Add(btnBookings);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 617);
            panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            // btnRoomTier
            // 
            btnRoomTier.FlatAppearance.BorderSize = 0;
            btnRoomTier.FlatStyle = FlatStyle.Flat;
            btnRoomTier.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRoomTier.IconChar = FontAwesome.Sharp.IconChar.Hotel;
            btnRoomTier.IconColor = Color.Black;
            btnRoomTier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRoomTier.ImageAlign = ContentAlignment.MiddleLeft;
            btnRoomTier.Location = new Point(11, 227);
            btnRoomTier.Name = "btnRoomTier";
            btnRoomTier.Size = new Size(191, 41);
            btnRoomTier.TabIndex = 1;
            btnRoomTier.Text = "Room Tier";
            btnRoomTier.UseVisualStyleBackColor = true;
            btnRoomTier.Click += btnRoomTier_Click;
            // 
            // btnRooms
            // 
            btnRooms.FlatAppearance.BorderSize = 0;
            btnRooms.FlatStyle = FlatStyle.Flat;
            btnRooms.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRooms.IconChar = FontAwesome.Sharp.IconChar.Bed;
            btnRooms.IconColor = Color.Black;
            btnRooms.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRooms.ImageAlign = ContentAlignment.MiddleLeft;
            btnRooms.Location = new Point(11, 167);
            btnRooms.Name = "btnRooms";
            btnRooms.Size = new Size(191, 41);
            btnRooms.TabIndex = 1;
            btnRooms.Text = "Rooms";
            btnRooms.UseVisualStyleBackColor = true;
            btnRooms.Click += btnRooms_Click;
            // 
            // btnBookings
            // 
            btnBookings.FlatAppearance.BorderSize = 0;
            btnBookings.FlatStyle = FlatStyle.Flat;
            btnBookings.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBookings.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            btnBookings.IconColor = Color.Black;
            btnBookings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBookings.ImageAlign = ContentAlignment.MiddleLeft;
            btnBookings.Location = new Point(11, 120);
            btnBookings.Name = "btnBookings";
            btnBookings.Size = new Size(191, 41);
            btnBookings.TabIndex = 1;
            btnBookings.Text = "Bookings";
            btnBookings.UseVisualStyleBackColor = true;
            btnBookings.Click += btnBookings_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.MistyRose;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.IconChar = FontAwesome.Sharp.IconChar.House;
            btnDashboard.IconColor = Color.Black;
            btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(11, 62);
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
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(191, 30);
            label1.TabIndex = 0;
            label1.Text = "Admin Dashboard";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(13, 15);
            label2.Name = "label2";
            label2.Size = new Size(119, 30);
            label2.TabIndex = 0;
            label2.Text = "Dashboard";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Snow;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(224, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(728, 59);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(591, 11);
            label4.Name = "label4";
            label4.Size = new Size(116, 21);
            label4.TabIndex = 1;
            label4.Text = "Administrator";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(620, 32);
            label3.Name = "label3";
            label3.Size = new Size(58, 21);
            label3.TabIndex = 1;
            label3.Text = "Admin";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Snow;
            panel3.Controls.Add(iconPictureBox1);
            panel3.Controls.Add(lblTotalRooms);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(230, 84);
            panel3.Name = "panel3";
            panel3.Size = new Size(214, 104);
            panel3.TabIndex = 2;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.SeaShell;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Bed;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 52;
            iconPictureBox1.Location = new Point(18, 21);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(52, 56);
            iconPictureBox1.TabIndex = 1;
            iconPictureBox1.TabStop = false;
            // 
            // lblTotalRooms
            // 
            lblTotalRooms.AutoSize = true;
            lblTotalRooms.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalRooms.Location = new Point(93, 42);
            lblTotalRooms.Name = "lblTotalRooms";
            lblTotalRooms.Size = new Size(33, 37);
            lblTotalRooms.TabIndex = 0;
            lblTotalRooms.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(87, 21);
            label5.Name = "label5";
            label5.Size = new Size(100, 21);
            label5.TabIndex = 0;
            label5.Text = "Total Rooms";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Snow;
            panel4.Controls.Add(iconPictureBox2);
            panel4.Controls.Add(lblAvailableRooms);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(472, 84);
            panel4.Name = "panel4";
            panel4.Size = new Size(214, 104);
            panel4.TabIndex = 2;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.SeaShell;
            iconPictureBox2.ForeColor = SystemColors.ControlText;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            iconPictureBox2.IconColor = SystemColors.ControlText;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 52;
            iconPictureBox2.Location = new Point(18, 21);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(52, 56);
            iconPictureBox2.TabIndex = 1;
            iconPictureBox2.TabStop = false;
            // 
            // lblAvailableRooms
            // 
            lblAvailableRooms.AutoSize = true;
            lblAvailableRooms.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvailableRooms.Location = new Point(93, 42);
            lblAvailableRooms.Name = "lblAvailableRooms";
            lblAvailableRooms.Size = new Size(33, 37);
            lblAvailableRooms.TabIndex = 0;
            lblAvailableRooms.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(76, 21);
            label8.Name = "label8";
            label8.Size = new Size(131, 21);
            label8.TabIndex = 0;
            label8.Text = "Available Rooms";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Snow;
            panel5.Controls.Add(iconPictureBox3);
            panel5.Controls.Add(lblActiveBookings);
            panel5.Controls.Add(label10);
            panel5.Location = new Point(717, 84);
            panel5.Name = "panel5";
            panel5.Size = new Size(214, 104);
            panel5.TabIndex = 2;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.SeaShell;
            iconPictureBox3.ForeColor = SystemColors.ControlText;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            iconPictureBox3.IconColor = SystemColors.ControlText;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 52;
            iconPictureBox3.Location = new Point(18, 21);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(52, 56);
            iconPictureBox3.TabIndex = 1;
            iconPictureBox3.TabStop = false;
            // 
            // lblActiveBookings
            // 
            lblActiveBookings.AutoSize = true;
            lblActiveBookings.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActiveBookings.Location = new Point(93, 42);
            lblActiveBookings.Name = "lblActiveBookings";
            lblActiveBookings.Size = new Size(33, 37);
            lblActiveBookings.TabIndex = 0;
            lblActiveBookings.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(76, 21);
            label10.Name = "label10";
            label10.Size = new Size(128, 21);
            label10.TabIndex = 0;
            label10.Text = "Active Bookings";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Snow;
            panel6.Controls.Add(btnViewAllBookings);
            panel6.Controls.Add(dgvRecentBookings);
            panel6.Controls.Add(label11);
            panel6.Location = new Point(230, 206);
            panel6.Name = "panel6";
            panel6.Size = new Size(697, 389);
            panel6.TabIndex = 3;
            // 
            // btnViewAllBookings
            // 
            btnViewAllBookings.BackColor = Color.Pink;
            btnViewAllBookings.FlatStyle = FlatStyle.Flat;
            btnViewAllBookings.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewAllBookings.Location = new Point(503, 345);
            btnViewAllBookings.Name = "btnViewAllBookings";
            btnViewAllBookings.Size = new Size(162, 28);
            btnViewAllBookings.TabIndex = 2;
            btnViewAllBookings.Text = "View all Bookings";
            btnViewAllBookings.UseVisualStyleBackColor = false;
            btnViewAllBookings.Click += btnViewAllBookings_Click;
            // 
            // dgvRecentBookings
            // 
            dgvRecentBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentBookings.Location = new Point(28, 60);
            dgvRecentBookings.Name = "dgvRecentBookings";
            dgvRecentBookings.Size = new Size(637, 270);
            dgvRecentBookings.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Crimson;
            label11.Location = new Point(22, 19);
            label11.Name = "label11";
            label11.Size = new Size(177, 30);
            label11.TabIndex = 0;
            label11.Text = "Recent Bookings";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(960, 616);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentBookings).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnRooms;
        private FontAwesome.Sharp.IconButton btnBookings;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private Panel panel3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label5;
        private Label lblTotalRooms;
        private Panel panel4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Label lblAvailableRooms;
        private Label label8;
        private Panel panel5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private Label lblActiveBookings;
        private Label label10;
        private Panel panel6;
        private DataGridView dgvRecentBookings;
        private Label label11;
        private Button btnViewAllBookings;
        private FontAwesome.Sharp.IconButton btnRoomTier;
    }
}