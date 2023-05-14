using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBServerAPI
{
    
    public class Form<file>
    {
        public Dictionary<string, file> files { get; set; }

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

            files = new Dictionary<string, file>();

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
