using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBServerAPI
{
    abstract public class Account
    {
        public string name { get; set; }
        public string password { get; set; }
    }
}
