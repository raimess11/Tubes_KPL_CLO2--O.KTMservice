using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O.KTMservice
{
    internal class Form<file>
    {
        private Dictionary<string, file> files = new Dictionary<string, file>();
        private Dictionary<string, string> data = new Dictionary<string, string>();
        public enum SERVICE_TYPE
        {
            PERBAIKAN_KTM,
            PENGGANTIAN_KTM
        }

        private void showPerbaikanForm()
        {
            Console.Write("Input KTM: ");
            files["KTM"] = (file)Convert.ChangeType(Console.ReadLine(), typeof(file));

            Console.Write("Input KSM: ");
            files["KSM"] = (file)Convert.ChangeType(Console.ReadLine(), typeof(file));

            Console.Write("Input Bukti Pembayaran: ");
            files["BuktiPembayaran"] = (file)Convert.ChangeType(Console.ReadLine(), typeof(file));
        }

        private void showPenggantianForm()
        {
            Console.Write("Input KSM: ");
            files["KSM"] = (file)Convert.ChangeType(Console.ReadLine(), typeof(file));

            Console.Write("Input Surat kehilangan: ");
            files["SuratKehilangan"] = (file)Convert.ChangeType(Console.ReadLine(), typeof(file));

            Console.Write("Input Bukti Pembayaran: ");
            files["BuktiPembayaran"] = (file)Convert.ChangeType(Console.ReadLine(), typeof(file));
        }

        public void showForm(string serviceType)
        {
            string input;
            SERVICE_TYPE service;

            Console.Write("Nama Lengkap: ");
            data["Nama"] = Console.ReadLine();

            Console.Write("NIM: ");
            data["NIM"] = Console.ReadLine();

            if (Enum.TryParse(serviceType, out service))
            {
                if (service == SERVICE_TYPE.PERBAIKAN_KTM)
                {
                    showPerbaikanForm();
                } else
                {
                    showPenggantianForm();
                }
            }
        } 
    }
}
