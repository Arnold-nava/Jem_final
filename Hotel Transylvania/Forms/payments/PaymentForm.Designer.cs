namespace Hotel_Transylvania.Forms.payments
{
    partial class PaymentForm
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
            btnBack = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            panel1 = new Panel();
            btnPayNow = new Button();
            txtPhoneNumber = new TextBox();
            txtEmail = new TextBox();
            txtFullName = new TextBox();
            panel2 = new Panel();
            label11 = new Label();
            lblTotalAmount = new Label();
            dtpCheckOut = new DateTimePicker();
            dtpCheckIn = new DateTimePicker();
            lblNight = new Label();
            lblCapacity = new Label();
            label10 = new Label();
            label9 = new Label();
            lblPrice = new Label();
            label6 = new Label();
            label8 = new Label();
            lblRoomNumber = new Label();
            label5 = new Label();
            label7 = new Label();
            lblRoomType = new Label();
            label4 = new Label();
            picRoom = new PictureBox();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picRoom).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            btnBack.IconColor = Color.Black;
            btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBack.IconSize = 25;
            btnBack.ImageAlign = ContentAlignment.MiddleLeft;
            btnBack.Location = new Point(24, 19);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(98, 33);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(167, 48);
            label1.Name = "label1";
            label1.Size = new Size(229, 32);
            label1.TabIndex = 1;
            label1.Text = "Complete Payment";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(btnPayNow);
            panel1.Controls.Add(txtPhoneNumber);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtFullName);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dtpCheckOut);
            panel1.Controls.Add(dtpCheckIn);
            panel1.Controls.Add(lblNight);
            panel1.Controls.Add(lblCapacity);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(lblPrice);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(lblRoomNumber);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lblRoomType);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(picRoom);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(15, 114);
            panel1.Name = "panel1";
            panel1.Size = new Size(514, 614);
            panel1.TabIndex = 2;
            // 
            // btnPayNow
            // 
            btnPayNow.BackColor = Color.Crimson;
            btnPayNow.FlatStyle = FlatStyle.Flat;
            btnPayNow.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayNow.ForeColor = SystemColors.ButtonHighlight;
            btnPayNow.Location = new Point(15, 530);
            btnPayNow.Name = "btnPayNow";
            btnPayNow.Size = new Size(487, 51);
            btnPayNow.TabIndex = 6;
            btnPayNow.Text = "Pay Now";
            btnPayNow.UseVisualStyleBackColor = false;
            btnPayNow.Click += btnPayNow_Click;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(182, 481);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "Enter Phone Number";
            txtPhoneNumber.Size = new Size(320, 27);
            txtPhoneNumber.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(182, 437);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter Email Address";
            txtEmail.Size = new Size(320, 27);
            txtEmail.TabIndex = 5;
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(182, 398);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "Enter Full Name";
            txtFullName.Size = new Size(320, 27);
            txtFullName.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Thistle;
            panel2.Controls.Add(label11);
            panel2.Controls.Add(lblTotalAmount);
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(13, 273);
            panel2.Name = "panel2";
            panel2.Size = new Size(491, 90);
            panel2.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Purple;
            label11.Location = new Point(184, 10);
            label11.Name = "label11";
            label11.Size = new Size(133, 25);
            label11.TabIndex = 0;
            label11.Text = "Total Amount";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmount.ForeColor = Color.Purple;
            lblTotalAmount.Location = new Point(220, 35);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(34, 40);
            lblTotalAmount.TabIndex = 0;
            lblTotalAmount.Text = "0";
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.Location = new Point(391, 155);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.Size = new Size(113, 27);
            dtpCheckOut.TabIndex = 3;
            dtpCheckOut.ValueChanged += dtpCheckOut_ValueChanged;
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.Location = new Point(391, 124);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(113, 27);
            dtpCheckIn.TabIndex = 3;
            dtpCheckIn.ValueChanged += dtpCheckIn_ValueChanged_1;
            // 
            // lblNight
            // 
            lblNight.AutoSize = true;
            lblNight.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNight.Location = new Point(390, 190);
            lblNight.Name = "lblNight";
            lblNight.Size = new Size(49, 20);
            lblNight.TabIndex = 2;
            lblNight.Text = "Night";
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCapacity.Location = new Point(391, 222);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(68, 20);
            lblCapacity.TabIndex = 2;
            lblCapacity.Text = "Capacity";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(234, 222);
            label10.Name = "label10";
            label10.Size = new Size(68, 20);
            label10.TabIndex = 2;
            label10.Text = "Capacity";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(234, 190);
            label9.Name = "label9";
            label9.Size = new Size(49, 20);
            label9.TabIndex = 2;
            label9.Text = "Night";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(390, 99);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(114, 20);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Price Per Night";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(234, 99);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 2;
            label6.Text = "Price Per Night";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(234, 160);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 2;
            label8.Text = "Check Out";
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomNumber.Location = new Point(390, 69);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new Size(113, 20);
            lblRoomNumber.TabIndex = 2;
            lblRoomNumber.Text = "Room Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(234, 69);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 2;
            label5.Text = "Room Number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(234, 129);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 2;
            label7.Text = "Check In";
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomType.Location = new Point(390, 38);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(88, 20);
            lblRoomType.TabIndex = 2;
            lblRoomType.Text = "Room Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(234, 38);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 2;
            label4.Text = "Room Type";
            // 
            // picRoom
            // 
            picRoom.Location = new Point(16, 38);
            picRoom.Name = "picRoom";
            picRoom.Size = new Size(195, 204);
            picRoom.SizeMode = PictureBoxSizeMode.StretchImage;
            picRoom.TabIndex = 1;
            picRoom.TabStop = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(15, 488);
            label19.Name = "label19";
            label19.Size = new Size(117, 20);
            label19.TabIndex = 0;
            label19.Text = "Phone NUmber";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(15, 444);
            label18.Name = "label18";
            label18.Size = new Size(108, 20);
            label18.TabIndex = 0;
            label18.Text = "Email Address";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(15, 405);
            label17.Name = "label17";
            label17.Size = new Size(80, 20);
            label17.TabIndex = 0;
            label17.Text = "Full Name";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Purple;
            label16.Location = new Point(13, 376);
            label16.Name = "label16";
            label16.Size = new Size(139, 20);
            label16.TabIndex = 0;
            label16.Text = "Guest Information";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Purple;
            label3.Location = new Point(9, 9);
            label3.Name = "label3";
            label3.Size = new Size(202, 25);
            label3.TabIndex = 0;
            label3.Text = "BOOKING SUMMARY";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 80);
            label2.Name = "label2";
            label2.Size = new Size(420, 20);
            label2.TabIndex = 1;
            label2.Text = "Please review your booking details and confirm your payment.";
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(541, 754);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Name = "PaymentForm";
            Text = "f";
            Load += PaymentForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picRoom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnBack;
        private Label label1;
        private Panel panel1;
        private Label label9;
        private Label label6;
        private Label label8;
        private Label label5;
        private Label label7;
        private Label label4;
        private PictureBox picRoom;
        private Label label3;
        private Label label2;
        private TextBox txtPhoneNumber;
        private TextBox txtEmail;
        private TextBox txtFullName;
        private Panel panel2;
        private Label label11;
        private Label lblTotalAmount;
        private DateTimePicker dtpCheckOut;
        private DateTimePicker dtpCheckIn;
        private Label lblNight;
        private Label lblPrice;
        private Label lblRoomNumber;
        private Label lblRoomType;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Button btnPayNow;
        private Label lblCapacity;
        private Label label10;
    }
}