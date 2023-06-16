namespace OKTMserviceWindows
{
    partial class MainMenu
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
            _headerPanel = new Panel();
            _loginButton = new Button();
            _menuPanel = new Panel();
            _buttonsPanel = new Panel();
            _penggantianKtmButton = new Button();
            _laporKtmButton = new Button();
            _perbaikanKtmButton = new Button();
            _arrowKiriButton = new Button();
            _arrowKananButton = new Button();
            pictureBox1 = new PictureBox();
            _headerPanel.SuspendLayout();
            _menuPanel.SuspendLayout();
            _buttonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // _headerPanel
            // 
            _headerPanel.BackColor = Color.FromArgb(192, 0, 0);
            _headerPanel.Controls.Add(_loginButton);
            _headerPanel.Location = new Point(3, 3);
            _headerPanel.Name = "_headerPanel";
            _headerPanel.Size = new Size(805, 50);
            _headerPanel.TabIndex = 1;
            // 
            // _loginButton
            // 
            _loginButton.BackColor = Color.FromArgb(192, 0, 0);
            _loginButton.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            _loginButton.ForeColor = Color.White;
            _loginButton.Location = new Point(739, 13);
            _loginButton.Name = "_loginButton";
            _loginButton.Size = new Size(52, 34);
            _loginButton.TabIndex = 8;
            _loginButton.Text = "Login";
            _loginButton.UseVisualStyleBackColor = false;
            // 
            // _menuPanel
            // 
            _menuPanel.Controls.Add(_buttonsPanel);
            _menuPanel.Controls.Add(_arrowKiriButton);
            _menuPanel.Controls.Add(_arrowKananButton);
            _menuPanel.Controls.Add(pictureBox1);
            _menuPanel.Controls.Add(_headerPanel);
            _menuPanel.Location = new Point(-6, -9);
            _menuPanel.Name = "_menuPanel";
            _menuPanel.Size = new Size(811, 465);
            _menuPanel.TabIndex = 2;
            // 
            // _buttonsPanel
            // 
            _buttonsPanel.Controls.Add(_penggantianKtmButton);
            _buttonsPanel.Controls.Add(_laporKtmButton);
            _buttonsPanel.Controls.Add(_perbaikanKtmButton);
            _buttonsPanel.Location = new Point(236, 322);
            _buttonsPanel.Name = "_buttonsPanel";
            _buttonsPanel.Size = new Size(323, 92);
            _buttonsPanel.TabIndex = 8;
            // 
            // _penggantianKtmButton
            // 
            _penggantianKtmButton.BackColor = Color.FromArgb(192, 0, 0);
            _penggantianKtmButton.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            _penggantianKtmButton.ForeColor = Color.White;
            _penggantianKtmButton.Location = new Point(3, 3);
            _penggantianKtmButton.Name = "_penggantianKtmButton";
            _penggantianKtmButton.Size = new Size(90, 84);
            _penggantianKtmButton.TabIndex = 5;
            _penggantianKtmButton.Text = "Penggantian KTM";
            _penggantianKtmButton.UseVisualStyleBackColor = false;
            // 
            // _laporKtmButton
            // 
            _laporKtmButton.BackColor = Color.FromArgb(192, 0, 0);
            _laporKtmButton.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            _laporKtmButton.ForeColor = Color.White;
            _laporKtmButton.Location = new Point(233, 3);
            _laporKtmButton.Name = "_laporKtmButton";
            _laporKtmButton.Size = new Size(90, 84);
            _laporKtmButton.TabIndex = 7;
            _laporKtmButton.Text = "Lapor KTM";
            _laporKtmButton.UseVisualStyleBackColor = false;
            // 
            // _perbaikanKtmButton
            // 
            _perbaikanKtmButton.BackColor = Color.FromArgb(192, 0, 0);
            _perbaikanKtmButton.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            _perbaikanKtmButton.ForeColor = Color.White;
            _perbaikanKtmButton.Location = new Point(118, 3);
            _perbaikanKtmButton.Name = "_perbaikanKtmButton";
            _perbaikanKtmButton.Size = new Size(90, 84);
            _perbaikanKtmButton.TabIndex = 6;
            _perbaikanKtmButton.Text = "Perbaikan KTM";
            _perbaikanKtmButton.UseVisualStyleBackColor = false;
            // 
            // _arrowKiriButton
            // 
            _arrowKiriButton.BackColor = SystemColors.ControlLight;
            _arrowKiriButton.Location = new Point(103, 173);
            _arrowKiriButton.Name = "_arrowKiriButton";
            _arrowKiriButton.Size = new Size(24, 23);
            _arrowKiriButton.TabIndex = 4;
            _arrowKiriButton.Text = "<";
            _arrowKiriButton.UseVisualStyleBackColor = false;
            // 
            // _arrowKananButton
            // 
            _arrowKananButton.BackColor = SystemColors.ControlLight;
            _arrowKananButton.Location = new Point(682, 173);
            _arrowKananButton.Name = "_arrowKananButton";
            _arrowKananButton.Size = new Size(24, 23);
            _arrowKananButton.TabIndex = 3;
            _arrowKananButton.Text = ">";
            _arrowKananButton.UseVisualStyleBackColor = false;
            _arrowKananButton.Click += _arrowKananButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imagePenggunaanWebsite;
            pictureBox1.Location = new Point(146, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(518, 219);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(_menuPanel);
            Name = "MainMenu";
            Text = "MainMenu";
            _headerPanel.ResumeLayout(false);
            _menuPanel.ResumeLayout(false);
            _buttonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel _headerPanel;
        private Panel _menuPanel;
        private Button _arrowKananButton;
        private PictureBox pictureBox1;
        private Button _arrowKiriButton;
        private Button _penggantianKtmButton;
        private Panel _buttonsPanel;
        private Button _laporKtmButton;
        private Button _perbaikanKtmButton;
        private Button _loginButton;
    }
}