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
        PENGGANTIAN_KTM,
        KTM_BERMASALAH
    }
    public enum REQUEST_STATUS
    {
        BerhasilVerifikasi,
        GagalVerifikasi,
        Mulai,
        BisaAbsen,
        BisaAksesFasilitas,
        Selesai
    }
    
    public class Request
    {
        public SERVICE_TYPE serviceType { get; set; }
        public Mahasiswa mahasiswa { get; set; }
        public Form form { get; set; }
        public REQUEST_STATUS requestStatus { get; set; }

        public Request(SERVICE_TYPE serviceType, Mahasiswa mahasiswa, Form form, REQUEST_STATUS requestStatus)
        {
            this.serviceType = serviceType;
            this.mahasiswa = mahasiswa;
            this.form = form;
            this.requestStatus = requestStatus;
        }
    }
}
