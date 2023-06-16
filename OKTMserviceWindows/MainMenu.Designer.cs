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
            panel1 = new Panel();
            button3 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            button4 = new Button();
            button6 = new Button();
            button5 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 0, 0);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(805, 50);
            panel1.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 0, 0);
            button3.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button3.ForeColor = Color.White;
            button3.Location = new Point(739, 13);
            button3.Name = "button3";
            button3.Size = new Size(52, 34);
            button3.TabIndex = 8;
            button3.Text = "Login";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(-6, -9);
            panel2.Name = "panel2";
            panel2.Size = new Size(811, 465);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button5);
            panel3.Location = new Point(236, 322);
            panel3.Name = "panel3";
            panel3.Size = new Size(323, 92);
            panel3.TabIndex = 8;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(192, 0, 0);
            button4.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button4.ForeColor = Color.White;
            button4.Location = new Point(3, 3);
            button4.Name = "button4";
            button4.Size = new Size(90, 84);
            button4.TabIndex = 5;
            button4.Text = "Penggantian KTM";
            button4.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(192, 0, 0);
            button6.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button6.ForeColor = Color.White;
            button6.Location = new Point(233, 3);
            button6.Name = "button6";
            button6.Size = new Size(90, 84);
            button6.TabIndex = 7;
            button6.Text = "Lapor KTM";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(192, 0, 0);
            button5.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button5.ForeColor = Color.White;
            button5.Location = new Point(118, 3);
            button5.Name = "button5";
            button5.Size = new Size(90, 84);
            button5.TabIndex = 6;
            button5.Text = "Perbaikan KTM";
            button5.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.Location = new Point(103, 173);
            button2.Name = "button2";
            button2.Size = new Size(24, 23);
            button2.TabIndex = 4;
            button2.Text = "<";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Location = new Point(682, 173);
            button1.Name = "button1";
            button1.Size = new Size(24, 23);
            button1.TabIndex = 3;
            button1.Text = ">";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            Controls.Add(panel2);
            Name = "MainMenu";
            Text = "MainMenu";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button4;
        private Panel panel3;
        private Button button6;
        private Button button5;
        private Button button3;
    }
}