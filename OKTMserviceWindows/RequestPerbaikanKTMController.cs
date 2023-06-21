using MenyantumkanDokumen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using OKTMserviceWindows;
using System.IO;

namespace O.KTMservice
{
    public class RequestPerbaikanKTMController
    {
        // Deklarasi atribut RequestPerbaikanKTMView untuk controller.
        private RequestPerbaikanKTMView requestPerbaikanKTMView;

        // Deklarasi atribut filesPath untuk menyimpan byte gambar.
        public static Dictionary<string, CantumFoto.Foto> filesByte { get; set; } = FileClass<CantumFoto.Foto>.filesDictionary;

        // Konstruktor untuk kelas RequestPerbaikanKTMController dan pendefinisian atribut.
        public RequestPerbaikanKTMController()
        {
            requestPerbaikanKTMView = new RequestPerbaikanKTMView(this);
        }

        // Inner class FileClass untuk menampung file data generics.
        public static class FileClass<T>
        {
            public static Dictionary<string, T> filesDictionary = new Dictionary<string, T>();
        }

        // Controller untuk submit request perbaikan KTM.
        public void SubmitRequestPerbaikanKTM()
        {

            // Deklarasi variable string untuk setiap text box.
            string tahunAjar = requestPerbaikanKTMView.TahunAjarLabel;
            string programStudi = requestPerbaikanKTMView.ProgramStudiLabel;
            string uploadedKSM = requestPerbaikanKTMView.UploadKSMLabel;
            string uploadedKTM = requestPerbaikanKTMView.UploadKTMLabel;
            string uploadedBuktiPembayaran = requestPerbaikanKTMView.UploadPembayaranLabel;

            // Pengujian kode dengan assertion untuk menguji text box tidak kosong.
            Debug.Assert(!string.IsNullOrEmpty(tahunAjar), "Tahun Ajar tidak boleh kosong");
            Debug.Assert(!string.IsNullOrEmpty(programStudi), "Program Studi tidak boleh kosong");
            Debug.Assert(!string.IsNullOrEmpty(uploadedKSM), "KSM tidak boleh kosong");
            Debug.Assert(!string.IsNullOrEmpty(uploadedKTM), "KTM tidak boleh kosong");
            Debug.Assert(!string.IsNullOrEmpty(uploadedBuktiPembayaran), "Bukti Pembayaran tidak boleh kosong");

            // Menambahkan string key dengan byte image value pada atribut filesByte
            filesByte["KTM"] = CantumFoto.holdFotoAPI(uploadedKTM);
            filesByte["KSM"] = CantumFoto.holdFotoAPI(uploadedKSM);
            filesByte["BuktiPembayaran"] = CantumFoto.holdFotoAPI(uploadedBuktiPembayaran);
        }
    }
}
