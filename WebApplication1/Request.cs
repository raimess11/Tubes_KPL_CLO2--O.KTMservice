using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBServerAPI
{
    public enum SERVICE_TYPE
    {
        PERBAIKAN_KTM,
        PENGGANTIAN_KTM
    }
    public enum REQUEST_STATUS
    {

    }
    internal class Request
    {
        private SERVICE_TYPE serviceType;
        private Mahasiswa mahasiswa;
        private Form form;
        private REQUEST_STATUS status;
    }
}
