namespace OKTMserviceWindows
{
    partial class RequestPerbaikanKTMView
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
            panel3 = new Panel();
            infoLabel = new Label();
            panel2 = new Panel();
            submitButton = new Button();
            choosePembayaranButton = new Button();
            chooseKTMButton = new Button();
            chooseKSMButton = new Button();
            uploadPembayaranTextBox = new TextBox();
            uploadKTMTextBox = new TextBox();
            uploadKSMTextBox = new TextBox();
            programStudiTextBox = new TextBox();
            tahunAjarTextBox = new TextBox();
            colonLabel5 = new Label();
            colonLabel4 = new Label();
            colonLabel3 = new Label();
            colonLabel2 = new Label();
            colonLabel1 = new Label();
            uploadPembayaranLabel = new Label();
            uploadKTMLabel = new Label();
            uploadKSMLabel = new Label();
            programStudiLabel = new Label();
            tahunAjarLabel = new Label();
            nimLabel = new Label();
            nimMahasiswaLabel = new Label();
            namaLabel = new Label();
            namaMahasiswaLabel = new Label();
            panel1 = new Panel();
            hasilLabel = new Label();
            pengajuanLabel = new Label();
            homeLabel = new Label();
            namaAkunLabel = new Label();
            openFileDialog = new OpenFileDialog();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 0, 0);
            panel3.Controls.Add(infoLabel);
            panel3.Location = new Point(28, 65);
            panel3.Name = "panel3";
            panel3.Size = new Size(743, 38);
            panel3.TabIndex = 4;
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            infoLabel.ForeColor = Color.White;
            infoLabel.Location = new Point(42, 9);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(192, 20);
            infoLabel.TabIndex = 0;
            infoLabel.Text = "Pengajuan Perbaikan KTM";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(submitButton);
            panel2.Controls.Add(choosePembayaranButton);
            panel2.Controls.Add(chooseKTMButton);
            panel2.Controls.Add(chooseKSMButton);
            panel2.Controls.Add(uploadPembayaranTextBox);
            panel2.Controls.Add(uploadKTMTextBox);
            panel2.Controls.Add(uploadKSMTextBox);
            panel2.Controls.Add(programStudiTextBox);
            panel2.Controls.Add(tahunAjarTextBox);
            panel2.Controls.Add(colonLabel5);
            panel2.Controls.Add(colonLabel4);
            panel2.Controls.Add(colonLabel3);
            panel2.Controls.Add(colonLabel2);
            panel2.Controls.Add(colonLabel1);
            panel2.Controls.Add(uploadPembayaranLabel);
            panel2.Controls.Add(uploadKTMLabel);
            panel2.Controls.Add(uploadKSMLabel);
            panel2.Controls.Add(programStudiLabel);
            panel2.Controls.Add(tahunAjarLabel);
            panel2.Controls.Add(nimLabel);
            panel2.Controls.Add(nimMahasiswaLabel);
            panel2.Controls.Add(namaLabel);
            panel2.Controls.Add(namaMahasiswaLabel);
            panel2.Location = new Point(28, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(743, 379);
            panel2.TabIndex = 3;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(310, 329);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(94, 29);
            submitButton.TabIndex = 21;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // choosePembayaranButton
            // 
            choosePembayaranButton.Location = new Point(525, 282);
            choosePembayaranButton.Name = "choosePembayaranButton";
            choosePembayaranButton.Size = new Size(94, 29);
            choosePembayaranButton.TabIndex = 20;
            choosePembayaranButton.Text = "Choose File";
            choosePembayaranButton.UseVisualStyleBackColor = true;
            choosePembayaranButton.Click += choosePembayaranButton_Click;
            // 
            // chooseKTMButton
            // 
            chooseKTMButton.Location = new Point(525, 233);
            chooseKTMButton.Name = "chooseKTMButton";
            chooseKTMButton.Size = new Size(94, 29);
            chooseKTMButton.TabIndex = 20;
            chooseKTMButton.Text = "Choose File";
            chooseKTMButton.UseVisualStyleBackColor = true;
            chooseKTMButton.Click += chooseKTMButton_Click;
            // 
            // chooseKSMButton
            // 
            chooseKSMButton.Location = new Point(525, 191);
            chooseKSMButton.Name = "chooseKSMButton";
            chooseKSMButton.Size = new Size(94, 29);
            chooseKSMButton.TabIndex = 19;
            chooseKSMButton.Text = "Choose File";
            chooseKSMButton.UseVisualStyleBackColor = true;
            chooseKSMButton.Click += chooseKSMButton_Click;
            // 
            // uploadPembayaranTextBox
            // 
            uploadPembayaranTextBox.Location = new Point(209, 284);
            uploadPembayaranTextBox.Name = "uploadPembayaranTextBox";
            uploadPembayaranTextBox.Size = new Size(300, 27);
            uploadPembayaranTextBox.TabIndex = 18;
            // 
            // uploadKTMTextBox
            // 
            uploadKTMTextBox.Location = new Point(209, 234);
            uploadKTMTextBox.Name = "uploadKTMTextBox";
            uploadKTMTextBox.Size = new Size(300, 27);
            uploadKTMTextBox.TabIndex = 17;
            // 
            // uploadKSMTextBox
            // 
            uploadKSMTextBox.Location = new Point(209, 192);
            uploadKSMTextBox.Name = "uploadKSMTextBox";
            uploadKSMTextBox.Size = new Size(300, 27);
            uploadKSMTextBox.TabIndex = 16;
            // 
            // programStudiTextBox
            // 
            programStudiTextBox.Location = new Point(209, 147);
            programStudiTextBox.Name = "programStudiTextBox";
            programStudiTextBox.Size = new Size(410, 27);
            programStudiTextBox.TabIndex = 15;
            // 
            // tahunAjarTextBox
            // 
            tahunAjarTextBox.Location = new Point(209, 106);
            tahunAjarTextBox.Name = "tahunAjarTextBox";
            tahunAjarTextBox.Size = new Size(410, 27);
            tahunAjarTextBox.TabIndex = 14;
            // 
            // colonLabel5
            // 
            colonLabel5.AutoSize = true;
            colonLabel5.Location = new Point(185, 287);
            colonLabel5.Name = "colonLabel5";
            colonLabel5.Size = new Size(12, 20);
            colonLabel5.TabIndex = 13;
            colonLabel5.Text = ":";
            // 
            // colonLabel4
            // 
            colonLabel4.AutoSize = true;
            colonLabel4.Location = new Point(185, 237);
            colonLabel4.Name = "colonLabel4";
            colonLabel4.Size = new Size(12, 20);
            colonLabel4.TabIndex = 12;
            colonLabel4.Text = ":";
            // 
            // colonLabel3
            // 
            colonLabel3.AutoSize = true;
            colonLabel3.Location = new Point(185, 195);
            colonLabel3.Name = "colonLabel3";
            colonLabel3.Size = new Size(12, 20);
            colonLabel3.TabIndex = 11;
            colonLabel3.Text = ":";
            // 
            // colonLabel2
            // 
            colonLabel2.AutoSize = true;
            colonLabel2.Location = new Point(185, 150);
            colonLabel2.Name = "colonLabel2";
            colonLabel2.Size = new Size(12, 20);
            colonLabel2.TabIndex = 10;
            colonLabel2.Text = ":";
            // 
            // colonLabel1
            // 
            colonLabel1.AutoSize = true;
            colonLabel1.Location = new Point(185, 109);
            colonLabel1.Name = "colonLabel1";
            colonLabel1.Size = new Size(12, 20);
            colonLabel1.TabIndex = 9;
            colonLabel1.Text = ":";
            // 
            // uploadPembayaranLabel
            // 
            uploadPembayaranLabel.AutoSize = true;
            uploadPembayaranLabel.Location = new Point(41, 276);
            uploadPembayaranLabel.Name = "uploadPembayaranLabel";
            uploadPembayaranLabel.Size = new Size(95, 40);
            uploadPembayaranLabel.TabIndex = 8;
            uploadPembayaranLabel.Text = "Upload Bukti\r\nPembayaran";
            // 
            // uploadKTMLabel
            // 
            uploadKTMLabel.AutoSize = true;
            uploadKTMLabel.Location = new Point(41, 237);
            uploadKTMLabel.Name = "uploadKTMLabel";
            uploadKTMLabel.Size = new Size(92, 20);
            uploadKTMLabel.TabIndex = 7;
            uploadKTMLabel.Text = "Upload KTM";
            // 
            // uploadKSMLabel
            // 
            uploadKSMLabel.AutoSize = true;
            uploadKSMLabel.Location = new Point(41, 195);
            uploadKSMLabel.Name = "uploadKSMLabel";
            uploadKSMLabel.Size = new Size(92, 20);
            uploadKSMLabel.TabIndex = 6;
            uploadKSMLabel.Text = "Upload KSM";
            // 
            // programStudiLabel
            // 
            programStudiLabel.AutoSize = true;
            programStudiLabel.Location = new Point(41, 150);
            programStudiLabel.Name = "programStudiLabel";
            programStudiLabel.Size = new Size(104, 20);
            programStudiLabel.TabIndex = 5;
            programStudiLabel.Text = "Program Studi";
            // 
            // tahunAjarLabel
            // 
            tahunAjarLabel.AutoSize = true;
            tahunAjarLabel.Location = new Point(41, 109);
            tahunAjarLabel.Name = "tahunAjarLabel";
            tahunAjarLabel.Size = new Size(78, 20);
            tahunAjarLabel.TabIndex = 4;
            tahunAjarLabel.Text = "Tahun Ajar";
            // 
            // nimLabel
            // 
            nimLabel.AutoSize = true;
            nimLabel.Location = new Point(530, 53);
            nimLabel.Name = "nimLabel";
            nimLabel.Size = new Size(89, 20);
            nimLabel.TabIndex = 3;
            nimLabel.Text = "1302213011";
            // 
            // nimMahasiswaLabel
            // 
            nimMahasiswaLabel.AutoSize = true;
            nimMahasiswaLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nimMahasiswaLabel.Location = new Point(469, 53);
            nimMahasiswaLabel.Name = "nimMahasiswaLabel";
            nimMahasiswaLabel.Size = new Size(40, 20);
            nimMahasiswaLabel.TabIndex = 2;
            nimMahasiswaLabel.Text = "NIM";
            // 
            // namaLabel
            // 
            namaLabel.AutoSize = true;
            namaLabel.Location = new Point(209, 53);
            namaLabel.Name = "namaLabel";
            namaLabel.Size = new Size(173, 20);
            namaLabel.TabIndex = 1;
            namaLabel.Text = "ALIF TAUFIQURRAHMAN";
            // 
            // namaMahasiswaLabel
            // 
            namaMahasiswaLabel.AutoSize = true;
            namaMahasiswaLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            namaMahasiswaLabel.Location = new Point(41, 53);
            namaMahasiswaLabel.Name = "namaMahasiswaLabel";
            namaMahasiswaLabel.Size = new Size(132, 20);
            namaMahasiswaLabel.TabIndex = 0;
            namaMahasiswaLabel.Text = "Nama Mahasiswa";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 0, 0);
            panel1.Controls.Add(hasilLabel);
            panel1.Controls.Add(pengajuanLabel);
            panel1.Controls.Add(homeLabel);
            panel1.Controls.Add(namaAkunLabel);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 41);
            panel1.TabIndex = 2;
            // 
            // hasilLabel
            // 
            hasilLabel.AutoSize = true;
            hasilLabel.ForeColor = Color.White;
            hasilLabel.Location = new Point(199, 9);
            hasilLabel.Name = "hasilLabel";
            hasilLabel.Size = new Size(42, 20);
            hasilLabel.TabIndex = 3;
            hasilLabel.Text = "Hasil";
            // 
            // pengajuanLabel
            // 
            pengajuanLabel.AutoSize = true;
            pengajuanLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            pengajuanLabel.ForeColor = Color.White;
            pengajuanLabel.Location = new Point(97, 9);
            pengajuanLabel.Name = "pengajuanLabel";
            pengajuanLabel.Size = new Size(82, 20);
            pengajuanLabel.TabIndex = 2;
            pengajuanLabel.Text = "Pengajuan";
            // 
            // homeLabel
            // 
            homeLabel.AutoSize = true;
            homeLabel.ForeColor = Color.White;
            homeLabel.Location = new Point(27, 9);
            homeLabel.Name = "homeLabel";
            homeLabel.Size = new Size(50, 20);
            homeLabel.TabIndex = 1;
            homeLabel.Text = "Home";
            // 
            // namaAkunLabel
            // 
            namaAkunLabel.AutoSize = true;
            namaAkunLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            namaAkunLabel.ForeColor = Color.White;
            namaAkunLabel.Location = new Point(581, 9);
            namaAkunLabel.Name = "namaAkunLabel";
            namaAkunLabel.Size = new Size(189, 20);
            namaAkunLabel.TabIndex = 0;
            namaAkunLabel.Text = "ALIF TAUFIQURRAHMAN";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // RequestPerbaikanKTMView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "RequestPerbaikanKTMView";
            Text = "RequestPerbaikanKTM";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label infoLabel;
        private Panel panel2;
        private Button submitButton;
        private Button choosePembayaranButton;
        private Button chooseKTMButton;
        private Button chooseKSMButton;
        private TextBox uploadPembayaranTextBox;
        private TextBox uploadKTMTextBox;
        private TextBox uploadKSMTextBox;
        private TextBox programStudiTextBox;
        private TextBox tahunAjarTextBox;
        private Label colonLabel5;
        private Label colonLabel4;
        private Label colonLabel3;
        private Label colonLabel2;
        private Label colonLabel1;
        private Label uploadPembayaranLabel;
        private Label uploadKTMLabel;
        private Label uploadKSMLabel;
        private Label programStudiLabel;
        private Label tahunAjarLabel;
        private Label nimLabel;
        private Label nimMahasiswaLabel;
        private Label namaLabel;
        private Label namaMahasiswaLabel;
        private Panel panel1;
        private OpenFileDialog openFileDialog;
        private Label homeLabel;
        private Label namaAkunLabel;
        private Label hasilLabel;
        private Label pengajuanLabel;
    }
}