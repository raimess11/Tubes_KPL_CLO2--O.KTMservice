using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenyantumkanDokumen;

namespace DBServerAPI
{
    public class Form
    {
        public static Dictionary<string, CantumFoto.Foto> files { get; set; } = FileClass<CantumFoto.Foto>.files;

        public static class FileClass<T>
        {
            public static Dictionary<string, T> files = new Dictionary<string, T>();

        }

        private static void showPerbaikanForm()
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

        private static void showPenggantianForm()
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

        public static void showForm(string serviceType)
        {
            string input;
            SERVICE_TYPE service;


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
