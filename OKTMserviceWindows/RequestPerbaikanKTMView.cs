using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using O.KTMservice;

namespace OKTMserviceWindows
{
    public partial class RequestPerbaikanKTMView : Form
    {

        private RequestPerbaikanKTMController perbaikanKTMController;

        public RequestPerbaikanKTMView(RequestPerbaikanKTMController perbaikanKTMController)
        {
            this.perbaikanKTMController = perbaikanKTMController;
            InitializeComponent();
        }

        public string TahunAjarLabel
        {
            get { return tahunAjarTextBox.Text; }
            set { tahunAjarTextBox.Text = value; }
        }

        public string ProgramStudiLabel
        {
            get { return programStudiTextBox.Text; }
            set { programStudiTextBox.Text = value; }
        }

        public string UploadKSMLabel
        {
            get { return uploadKSMTextBox.Text; }
            set { uploadKSMTextBox.Text = value; }
        }

        public string UploadKTMLabel
        {
            get { return uploadKTMTextBox.Text; }
            set { uploadKTMTextBox.Text = value; }
        }

        public string UploadPembayaranLabel
        {
            get { return uploadPembayaranTextBox.Text; }
            set { uploadPembayaranTextBox.Text = value; }
        }

        private void chooseKSMButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                uploadKSMTextBox.Text = Path.GetFullPath(openFileDialog.FileName);
            }
            else
            {
                MessageBox.Show("Choose File");
            }
        }

        private void chooseKTMButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                uploadKTMTextBox.Text = Path.GetFullPath(openFileDialog.FileName);
            }
            else
            {
                MessageBox.Show("Choose File");
            }
        }

        private void choosePembayaranButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                uploadPembayaranTextBox.Text = Path.GetFullPath(openFileDialog.FileName);
            }
            else
            {
                MessageBox.Show("Choose File");
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            perbaikanKTMController.SubmitRequestPerbaikanKTM();
        }
    }
}
