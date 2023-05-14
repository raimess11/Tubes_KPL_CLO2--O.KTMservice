using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBServerAPI
{
    public class Account
    {
        static private int UIDgenerate {get; set;} = 0;
        static private int UID { get; set; }
        public string name {get; set;}
        public string password { get; set; }
        public Account()
        {
            UIDgenerate++;
            UID = UIDgenerate;
        }
        public Account(string name, string password)
        {
            this.name = name;
            this.password = password;
        }

        public int getUID() { return UID; }

    }
}
