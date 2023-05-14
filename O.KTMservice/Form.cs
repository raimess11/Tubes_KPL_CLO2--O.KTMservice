using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenyantumkanDokumen;

namespace DBServerAPI
{
    public enum SERVICE_TYPE
    {
        PERBAIKAN_KTM,
        PENGGANTIAN_KTM
    }
    public class Form
    {
        public Dictionary<string, CantumFoto.Foto> files { get; set; }

        private void showPerbaikanForm()
        {
            string path;

            Console.Write("Input KTM: ");
            path = Console.ReadLine();
            Debug.Assert(!string.IsNullOrEmpty(path), "Image path cannot empty.");
            files["KTM"] = CantumFoto.holdFotoAPI(path);

            Console.Write("Input KSM: ");
            path = Console.ReadLine();
            Debug.Assert(!string.IsNullOrEmpty(path), "Image path cannot empty.");
            files["KSM"] = CantumFoto.holdFotoAPI(path);

            Console.Write("Input Bukti Pembayaran: ");
            path = Console.ReadLine();
            Debug.Assert(!string.IsNullOrEmpty(path), "Image path cannot empty.");
            files["BuktiPembayaran"] = CantumFoto.holdFotoAPI(path);
        }

        private void showPenggantianForm()
        {
            string path;

            Console.Write("Input KSM: ");
            path = Console.ReadLine();
            Debug.Assert(!string.IsNullOrEmpty(path), "Image path cannot empty.");
            files["KSM"] = CantumFoto.holdFotoAPI(path);

            Console.Write("Input Surat kehilangan: ");
            path = Console.ReadLine();
            Debug.Assert(!string.IsNullOrEmpty(path), "Image path cannot empty.");
            files["SuratKehilangan"] = CantumFoto.holdFotoAPI(path);

            Console.Write("Input Bukti Pembayaran: ");
            path = Console.ReadLine();
            Debug.Assert(!string.IsNullOrEmpty(path), "Image path cannot empty.");
            files["BuktiPembayaran"] = CantumFoto.holdFotoAPI(path);
        }

        public void showForm(string serviceType)
        {
            string input;
            SERVICE_TYPE service;

            files = new Dictionary<string, CantumFoto.Foto>();

            if (Enum.TryParse(serviceType, out service))
            {
                if (service == SERVICE_TYPE.PERBAIKAN_KTM)
                {
                    showPerbaikanForm();
                }
                else
                {
                    showPenggantianForm();
                }
            }
        }

    }
}
