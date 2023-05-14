using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DBServerAPI
{
    public class Mahasiswa : Account
    {
        public int nim { get; set; }
        //image KSM;
        //image KTM;

        public Mahasiswa() { }
        public Mahasiswa(string nama, string password, int nim)
        {
            this.name = nama;
            this.password = password;
            this.nim = nim;
        }
    }
}
