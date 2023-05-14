using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBServerAPI
{
    public class Staff : Account
    {
        private int nip;
        public Staff()
        {

        }
        public Staff(string nama, string password, int nip)
        {
            this.name = nama;
            this.password = password;
            this.nip = nip;
        }
    }
}
