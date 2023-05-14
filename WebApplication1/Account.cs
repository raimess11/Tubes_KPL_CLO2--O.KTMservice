using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBServerAPI
{
    abstract public class Account
    {
        static private int UIDgenerate = 0;
        static private int UID;
        protected string name;
        protected string password;

        protected Account()
        {
            UIDgenerate++;
            UID = UIDgenerate;
        }

        public int getUID() { return UID; }

    }
}
