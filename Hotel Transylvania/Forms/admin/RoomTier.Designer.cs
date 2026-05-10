namespace Hotel_Transylvania.Forms.admin
{
    partial class RoomTier
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
            label7 = new Label();
            panel3 = new Panel();
            dgvRoomTiers = new DataGridView();
            btnClear = new Button();
            panel2 = new Panel();
            txtCapacity = new TextBox();
            txtPrice = new TextBox();
            label6 = new Label();
            label4 = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            cmbRoomTier = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            btnRoomTier = new FontAwesome.Sharp.IconButton();
            btnLogout = new FontAwesome.Sharp.IconButton();
            btnRooms = new FontAwesome.Sharp.IconButton();
            btnBooking = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoomTiers).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Crimson;
            label7.Location = new Point(22, 8);
            label7.Name = "label7";
            label7.Size = new Size(100, 25);
            label7.TabIndex = 0;
            label7.Text = "Room List";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Snow;
            panel3.Controls.Add(dgvRoomTiers);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(552, 62);
            panel3.Name = "panel3";
            panel3.Size = new Size(494, 534);
            panel3.TabIndex = 10;
            // 
            // dgvRoomTiers
            // 
            dgvRoomTiers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoomTiers.Location = new Point(22, 36);
            dgvRoomTiers.Name = "dgvRoomTiers";
            dgvRoomTiers.Size = new Size(457, 478);
            dgvRoomTiers.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LavenderBlush;
            btnClear.FlatAppearance.BorderSize = 2;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.ButtonShadow;
            btnClear.Location = new Point(13, 332);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(129, 40);
            btnClear.TabIndex = 3;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Snow;
            panel2.Controls.Add(txtCapacity);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(cmbRoomTier);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(237, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(297, 540);
            panel2.TabIndex = 9;
            // 
            // txtCapacity
            // 
            txtCapacity.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCapacity.ForeColor = Color.Crimson;
            txtCapacity.Location = new Point(13, 202);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.PlaceholderText = "Enter Capacity";
            txtCapacity.Size = new Size(230, 27);
            txtCapacity.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPrice.ForeColor = Color.Crimson;
            txtPrice.Location = new Point(13, 146);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Enter price";
            txtPrice.Size = new Size(230, 27);
            txtPrice.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.PaleVioletRed;
            label6.Location = new Point(13, 179);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 4;
            label6.Text = "Capacity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.PaleVioletRed;
            label4.Location = new Point(13, 123);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 4;
            label4.Text = "Price";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LavenderBlush;
            btnDelete.FlatAppearance.BorderSize = 2;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Crimson;
            btnDelete.Location = new Point(148, 286);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(129, 40);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LavenderBlush;
            btnUpdate.FlatAppearance.BorderSize = 2;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.Crimson;
            btnUpdate.Location = new Point(13, 286);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(129, 40);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cmbRoomTier
            // 
            cmbRoomTier.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbRoomTier.FormattingEnabled = true;
            cmbRoomTier.Location = new Point(13, 75);
            cmbRoomTier.Name = "cmbRoomTier";
            cmbRoomTier.Size = new Size(224, 29);
            cmbRoomTier.TabIndex = 2;
            cmbRoomTier.Text = "Select tier";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.PaleVioletRed;
            label5.Location = new Point(13, 52);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 0;
            label5.Text = "Room Tier";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(13, 12);
            label3.Name = "label3";
            label3.Size = new Size(216, 25);
            label3.TabIndex = 0;
            label3.Text = "Room Tier information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(237, 9);
            label2.Name = "label2";
            label2.Size = new Size(250, 30);
            label2.TabIndex = 8;
            label2.Text = "Room Tier Management";
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
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 617);
            panel1.TabIndex = 2;
            // 
            // btnRoomTier
            // 
            btnRoomTier.BackColor = Color.MistyRose;
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
            btnRoomTier.UseVisualStyleBackColor = false;
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
            btnBooking.BackColor = Color.LightCoral;
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
            // RoomTier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1094, 620);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label2);
            Name = "RoomTier";
            Text = "RoomTier";
            Load += RoomTier_Load_1;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoomTiers).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Panel panel3;
        private DataGridView dgvRoomTiers;
        private Button btnClear;
        private Panel panel2;
        private Button btnDelete;
        private Button btnUpdate;
        private ComboBox cmbRoomTier;
        private Label label5;
        private Label label3;
        private Label label2;
        private TextBox txtPrice;
        private Label label4;
        private TextBox txtCapacity;
        private Label label6;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnRoomTier;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnRooms;
        private FontAwesome.Sharp.IconButton btnBooking;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private Label label1;
    }
}