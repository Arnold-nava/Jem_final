namespace Hotel_Transylvania
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
            btnLoggin = new Button();
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.LightCoral;
            iconPictureBox1.ForeColor = Color.Pink;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Ghost;
            iconPictureBox1.IconColor = Color.Pink;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 198;
            iconPictureBox1.Location = new Point(0, 1);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(198, 433);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Curlz MT", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(240, 15);
            label1.Name = "label1";
            label1.Size = new Size(263, 43);
            label1.TabIndex = 1;
            label1.Text = "Hotel Transylvania";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(288, 93);
            label2.Name = "label2";
            label2.Size = new Size(170, 21);
            label2.TabIndex = 2;
            label2.Text = "Login to your account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(240, 133);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 3;
            label3.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(240, 157);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter your Username";
            txtUsername.Size = new Size(257, 29);
            txtUsername.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(240, 200);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(240, 224);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter your Password";
            txtPassword.Size = new Size(257, 29);
            txtPassword.TabIndex = 4;
            // 
            // btnLoggin
            // 
            btnLoggin.BackColor = Color.Pink;
            btnLoggin.FlatStyle = FlatStyle.Flat;
            btnLoggin.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoggin.Location = new Point(238, 285);
            btnLoggin.Name = "btnLoggin";
            btnLoggin.Size = new Size(256, 44);
            btnLoggin.TabIndex = 5;
            btnLoggin.Text = "Login";
            btnLoggin.UseVisualStyleBackColor = false;
            btnLoggin.Click += btnLoggin_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(418, 366);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(59, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign up";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Crimson;
            label5.Location = new Point(243, 365);
            label5.Name = "label5";
            label5.Size = new Size(176, 21);
            label5.TabIndex = 3;
            label5.Text = "Don't have an account?";
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.White;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Eye;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 25;
            iconButton1.Location = new Point(452, 227);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(42, 23);
            iconButton1.TabIndex = 7;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(562, 435);
            Controls.Add(iconButton1);
            Controls.Add(linkLabel1);
            Controls.Add(btnLoggin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(iconPictureBox1);
            Name = "LoginForm";
            Padding = new Padding(5, 15, 5, 15);
            Text = "Form1";
            Load += login_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private Label label4;
        private TextBox txtPassword;
        private Button btnLoggin;
        private LinkLabel linkLabel1;
        private Label label5;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}
