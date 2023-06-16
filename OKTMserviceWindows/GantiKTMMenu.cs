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
    public partial class GantiKTMMenu : DBServerAPI.Form
    {
        public GantiKTMMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // membuat request
            Request request = GantiKTMController.createRequest(
                    DBServerAPI.SERVICE_TYPE.PENGGANTIAN_KTM,
                    Client.mahasiswa,
                    _uploadKSMTeksBox.Text,
                    _labelUploadSuratKehilangan.Text,
                    _buktiPembayaran.Text
                );
            // mengupload ke server menggunakan API
            GantiKTMController.uploadRequestAsync( request );
        }

        private void GantiKTMMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
