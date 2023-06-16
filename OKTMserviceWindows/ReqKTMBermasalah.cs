using DBServerAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OKTMserviceWindows
{
    public partial class ReqKTMBermasalah : System.Windows.Forms.Form
    {
        public ReqKTMBermasalah()
        {
            InitializeComponent();
        }

        private void _buttonHome_Click(object sender, EventArgs e)
        {

        }

        private void buttonPengajuan_Click(object sender, EventArgs e)
        {

        }

        private void _buttonHasil_Click(object sender, EventArgs e)
        {

        }

        private void _buttonMasalah_Click(object sender, EventArgs e)
        {

        }

        private void _nama_Click(object sender, EventArgs e)
        {

        }

        private void _buttonSubmit_Click(object sender, EventArgs e)
        {
            Mahasiswa mahasiswa = new Mahasiswa();
            mahasiswa.name = _nama.Text;
            mahasiswa.nim = int.Parse(_nim.Text);
            Request req = ControllerReqKTMBermasalah.CreateRequest(SERVICE_TYPE.KTM_BERMASALAH, mahasiswa, _imagePathTxtBox.Text, _deskripsiMasalah.Text);
            ControllerReqKTMBermasalah.UploadRequest(req);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
