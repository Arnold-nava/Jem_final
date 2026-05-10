namespace Hotel_Transylvania.Forms.admin
{
    partial class RoomManagement
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
            label2 = new Label();
            panel2 = new Panel();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            cmbStatus = new ComboBox();
            cmbRoomTier = new ComboBox();
            txtRoomNumber = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            dgvRooms = new DataGridView();
            label7 = new Label();
            panel1 = new Panel();
            btnLogout = new FontAwesome.Sharp.IconButton();
            btnRoomTier = new FontAwesome.Sharp.IconButton();
            btnRooms = new FontAwesome.Sharp.IconButton();
            btnBookings = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(237, 10);
            label2.Name = "label2";
            label2.Size = new Size(207, 30);
            label2.TabIndex = 4;
            label2.Text = "Room Management";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Snow;
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(cmbStatus);
            panel2.Controls.Add(cmbRoomTier);
            panel2.Controls.Add(txtRoomNumber);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(237, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(297, 540);
            panel2.TabIndex = 5;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LavenderBlush;
            btnClear.FlatAppearance.BorderSize = 2;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.ButtonShadow;
            btnClear.Location = new Point(148, 332);
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
            btnDelete.Location = new Point(13, 332);
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
            btnUpdate.Location = new Point(148, 272);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(129, 40);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Crimson;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(13, 272);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(129, 40);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "+ ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(13, 211);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(224, 29);
            cmbStatus.TabIndex = 2;
            cmbStatus.Text = "Select status";
            // 
            // cmbRoomTier
            // 
            cmbRoomTier.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbRoomTier.FormattingEnabled = true;
            cmbRoomTier.Location = new Point(13, 146);
            cmbRoomTier.Name = "cmbRoomTier";
            cmbRoomTier.Size = new Size(224, 29);
            cmbRoomTier.TabIndex = 2;
            cmbRoomTier.Text = "Select tier";
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRoomNumber.ForeColor = Color.Crimson;
            txtRoomNumber.Location = new Point(13, 85);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.PlaceholderText = "Enter room number";
            txtRoomNumber.Size = new Size(230, 27);
            txtRoomNumber.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.PaleVioletRed;
            label6.Location = new Point(13, 188);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 0;
            label6.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.PaleVioletRed;
            label5.Location = new Point(13, 123);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 0;
            label5.Text = "Room Tier";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.PaleVioletRed;
            label4.Location = new Point(13, 62);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 0;
            label4.Text = "Room Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(13, 12);
            label3.Name = "label3";
            label3.Size = new Size(177, 25);
            label3.TabIndex = 0;
            label3.Text = "Room information";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Snow;
            panel3.Controls.Add(dgvRooms);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(552, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(494, 534);
            panel3.TabIndex = 6;
            // 
            // dgvRooms
            // 
            dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRooms.Location = new Point(22, 36);
            dgvRooms.Name = "dgvRooms";
            dgvRooms.Size = new Size(457, 478);
            dgvRooms.TabIndex = 1;
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
            // panel1
            // 
            panel1.BackColor = Color.LightCoral;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnRoomTier);
            panel1.Controls.Add(btnRooms);
            panel1.Controls.Add(btnBookings);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 617);
            panel1.TabIndex = 2;
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
            btnRooms.BackColor = Color.MistyRose;
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
            btnRooms.UseVisualStyleBackColor = false;
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
            // RoomManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1075, 618);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label2);
            Name = "RoomManagement";
            Text = "RoomManagement";
            Load += RoomManagement_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Button btnAdd;
        private ComboBox cmbStatus;
        private ComboBox cmbRoomTier;
        private TextBox txtRoomNumber;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Panel panel3;
        private DataGridView dgvRooms;
        private Label label7;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnRoomTier;
        private FontAwesome.Sharp.IconButton btnRooms;
        private FontAwesome.Sharp.IconButton btnBookings;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private Label label1;
    }
}