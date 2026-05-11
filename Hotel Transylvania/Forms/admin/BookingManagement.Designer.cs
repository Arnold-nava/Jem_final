namespace Hotel_Transylvania.Forms.admin
{
    partial class BookingManagement
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
            btnRoomTier = new FontAwesome.Sharp.IconButton();
            btnLogout = new FontAwesome.Sharp.IconButton();
            btnRooms = new FontAwesome.Sharp.IconButton();
            btnBooking = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            panel3 = new Panel();
            dgvBookings = new DataGridView();
            label7 = new Label();
            panel2 = new Panel();
            txtSearch = new TextBox();
            cmbRoom = new ComboBox();
            btnClear = new Button();
            btnDelete = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCoral;
            panel1.Controls.Add(btnRoomTier);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnRooms);
            panel1.Controls.Add(btnBooking);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 617);
            panel1.TabIndex = 1;
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
            btnRoomTier.Location = new Point(11, 240);
            btnRoomTier.Name = "btnRoomTier";
            btnRoomTier.Size = new Size(191, 41);
            btnRoomTier.TabIndex = 2;
            btnRoomTier.Text = "Room Tier";
            btnRoomTier.UseVisualStyleBackColor = true;
            btnRoomTier.Click += btnRoomTier_Click;
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
            // btnRooms
            // 
            btnRooms.FlatAppearance.BorderSize = 0;
            btnRooms.FlatStyle = FlatStyle.Flat;
            btnRooms.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRooms.IconChar = FontAwesome.Sharp.IconChar.Bed;
            btnRooms.IconColor = Color.Black;
            btnRooms.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRooms.ImageAlign = ContentAlignment.MiddleLeft;
            btnRooms.Location = new Point(11, 181);
            btnRooms.Name = "btnRooms";
            btnRooms.Size = new Size(191, 41);
            btnRooms.TabIndex = 1;
            btnRooms.Text = "Rooms";
            btnRooms.UseVisualStyleBackColor = true;
            btnRooms.Click += btnRooms_Click;
            // 
            // btnBooking
            // 
            btnBooking.BackColor = Color.MistyRose;
            btnBooking.FlatAppearance.BorderSize = 0;
            btnBooking.FlatStyle = FlatStyle.Flat;
            btnBooking.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooking.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            btnBooking.IconColor = Color.Black;
            btnBooking.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBooking.ImageAlign = ContentAlignment.MiddleLeft;
            btnBooking.Location = new Point(11, 120);
            btnBooking.Name = "btnBooking";
            btnBooking.Size = new Size(191, 41);
            btnBooking.TabIndex = 1;
            btnBooking.Text = "Bookings";
            btnBooking.UseVisualStyleBackColor = false;
            btnBooking.Click += btnBooking_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.LightCoral;
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
            // panel3
            // 
            panel3.BackColor = Color.Snow;
            panel3.Controls.Add(dgvBookings);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(551, 62);
            panel3.Name = "panel3";
            panel3.Size = new Size(546, 534);
            panel3.TabIndex = 12;
            // 
            // dgvBookings
            // 
            dgvBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookings.Location = new Point(22, 36);
            dgvBookings.Name = "dgvBookings";
            dgvBookings.Size = new Size(506, 478);
            dgvBookings.TabIndex = 1;
            dgvBookings.CellClick += dgvBookings_CellClick_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Crimson;
            label7.Location = new Point(22, 8);
            label7.Name = "label7";
            label7.Size = new Size(123, 25);
            label7.TabIndex = 0;
            label7.Text = "Booking List";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Snow;
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(cmbRoom);
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(236, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(297, 540);
            panel2.TabIndex = 11;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.Crimson;
            txtSearch.Location = new Point(13, 86);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Enter Customer Name";
            txtSearch.Size = new Size(261, 27);
            txtSearch.TabIndex = 5;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cmbRoom
            // 
            cmbRoom.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbRoom.ForeColor = Color.Crimson;
            cmbRoom.FormattingEnabled = true;
            cmbRoom.Location = new Point(13, 145);
            cmbRoom.Name = "cmbRoom";
            cmbRoom.Size = new Size(261, 28);
            cmbRoom.TabIndex = 4;
            cmbRoom.Tag = "";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LavenderBlush;
            btnClear.FlatAppearance.BorderSize = 2;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.ButtonShadow;
            btnClear.Location = new Point(148, 196);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(129, 40);
            btnClear.TabIndex = 3;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LavenderBlush;
            btnDelete.FlatAppearance.BorderSize = 2;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Crimson;
            btnDelete.Location = new Point(13, 196);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(129, 40);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.PaleVioletRed;
            label5.Location = new Point(13, 122);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 0;
            label5.Text = "Room NO.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.PaleVioletRed;
            label4.Location = new Point(13, 62);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 0;
            label4.Text = "Search";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(13, 12);
            label3.Name = "label3";
            label3.Size = new Size(200, 25);
            label3.TabIndex = 0;
            label3.Text = "Booking information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(236, 9);
            label2.Name = "label2";
            label2.Size = new Size(232, 30);
            label2.TabIndex = 10;
            label2.Text = "Booking Management";
            // 
            // BookingManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1109, 615);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "BookingManagement";
            Text = "BookingManagement";
            Load += BookingManagement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnRooms;
        private FontAwesome.Sharp.IconButton btnBooking;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private Label label1;
        private Panel panel3;
        private DataGridView dgvBookings;
        private Label label7;
        private Panel panel2;
        private Button btnClear;
        private Button btnDelete;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cmbRoom;
        private Label label5;
        private FontAwesome.Sharp.IconButton btnRoomTier;
        private TextBox txtSearch;
    }
}