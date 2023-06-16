namespace OKTMserviceWindows
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            panel2 = new Panel();
            password = new Label();
            username = new Label();
            showPassword = new CheckBox();
            btn_login = new Button();
            textBox_password = new TextBox();
            textBox_username = new TextBox();
            label_login = new Label();
            pictureBox_penggunaanWebsite = new PictureBox();
            btn_ToRight = new Button();
            btn_ToLeft = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_penggunaanWebsite).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 0, 0);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 48);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(password);
            panel2.Controls.Add(username);
            panel2.Controls.Add(showPassword);
            panel2.Controls.Add(btn_login);
            panel2.Controls.Add(textBox_password);
            panel2.Controls.Add(textBox_username);
            panel2.Controls.Add(label_login);
            panel2.Font = new Font("Arial Rounded MT Bold", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(517, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(283, 358);
            panel2.TabIndex = 1;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Arial Rounded MT Bold", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(48, 159);
            password.Name = "password";
            password.Size = new Size(48, 11);
            password.TabIndex = 6;
            password.Text = "password";
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Arial Rounded MT Bold", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(48, 110);
            username.Name = "username";
            username.Size = new Size(47, 11);
            username.TabIndex = 5;
            username.Text = "username";
            // 
            // showPassword
            // 
            showPassword.AutoSize = true;
            showPassword.Font = new Font("Arial Rounded MT Bold", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            showPassword.Location = new Point(48, 203);
            showPassword.Name = "showPassword";
            showPassword.Size = new Size(91, 15);
            showPassword.TabIndex = 4;
            showPassword.Text = "show password";
            showPassword.UseVisualStyleBackColor = true;
            showPassword.CheckedChanged += showPassword_CheckedChanged;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(192, 0, 0);
            btn_login.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_login.ForeColor = SystemColors.ButtonHighlight;
            btn_login.Location = new Point(163, 231);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(75, 23);
            btn_login.TabIndex = 3;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(48, 174);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(190, 20);
            textBox_password.TabIndex = 2;
            textBox_password.TextChanged += textBox_password_TextChanged;
            // 
            // textBox_username
            // 
            textBox_username.Location = new Point(48, 125);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(190, 20);
            textBox_username.TabIndex = 1;
            textBox_username.TextChanged += textBox_username_TextChanged;
            // 
            // label_login
            // 
            label_login.AutoSize = true;
            label_login.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_login.Location = new Point(115, 66);
            label_login.Name = "label_login";
            label_login.Size = new Size(60, 22);
            label_login.TabIndex = 0;
            label_login.Text = "Login";
            // 
            // pictureBox_penggunaanWebsite
            // 
            pictureBox_penggunaanWebsite.Image = (Image)resources.GetObject("pictureBox_penggunaanWebsite.Image");
            pictureBox_penggunaanWebsite.Location = new Point(-1, 46);
            pictureBox_penggunaanWebsite.Name = "pictureBox_penggunaanWebsite";
            pictureBox_penggunaanWebsite.Size = new Size(519, 358);
            pictureBox_penggunaanWebsite.TabIndex = 2;
            pictureBox_penggunaanWebsite.TabStop = false;
            pictureBox_penggunaanWebsite.Click += pictureBox_penggunaanWebsite_Click;
            // 
            // btn_ToRight
            // 
            btn_ToRight.BackColor = SystemColors.ControlLight;
            btn_ToRight.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ToRight.Location = new Point(485, 208);
            btn_ToRight.Name = "btn_ToRight";
            btn_ToRight.Size = new Size(26, 23);
            btn_ToRight.TabIndex = 3;
            btn_ToRight.Text = ">";
            btn_ToRight.UseVisualStyleBackColor = false;
            btn_ToRight.Click += btn_ToRight_Click;
            // 
            // btn_ToLeft
            // 
            btn_ToLeft.BackColor = SystemColors.ControlLight;
            btn_ToLeft.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ToLeft.Location = new Point(12, 205);
            btn_ToLeft.Name = "btn_ToLeft";
            btn_ToLeft.Size = new Size(26, 23);
            btn_ToLeft.TabIndex = 7;
            btn_ToLeft.Text = "<";
            btn_ToLeft.UseVisualStyleBackColor = false;
            btn_ToLeft.Click += btn_ToLeft_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 398);
            Controls.Add(btn_ToLeft);
            Controls.Add(btn_ToRight);
            Controls.Add(pictureBox_penggunaanWebsite);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Form1";
            Load += Login_Load_1;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_penggunaanWebsite).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btn_login;
        private TextBox textBox_password;
        private TextBox textBox_username;
        private Label label_login;
        private PictureBox pictureBox_penggunaanWebsite;
        private CheckBox showPassword;
        private Label password;
        private Label username;
        private Button btn_ToRight;
        private Button btn_ToLeft;
    }
}