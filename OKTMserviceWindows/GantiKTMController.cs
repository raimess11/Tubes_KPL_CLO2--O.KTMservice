using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenyantumkanDokumen;
using DBServerAPI;

namespace OKTMserviceWindows
{
    internal class GantiKTMController
    {
        public static Request createRequest(
            SERVICE_TYPE type, 
            Mahasiswa mahasiswa, 
            String pathLampiran1, 
            String pathLampiran2, 
            String pathLampiran3
            )
        {
            CantumFoto.Foto fotoLampiran1 = CantumFoto.holdFotoAPI(pathLampiran1);
            CantumFoto.Foto fotoLampiran2 = CantumFoto.holdFotoAPI(pathLampiran2);
            CantumFoto.Foto fotoLampiran3 = CantumFoto.holdFotoAPI(pathLampiran3);

            DBServerAPI.Form form = new DBServerAPI.Form();
            form.files.Add("KSM", fotoLampiran1);
            form.files.Add("Surat Kehilangan", fotoLampiran2);
            form.files.Add("Bukti Pembayaran", fotoLampiran3);

            return new Request(SERVICE_TYPE.PENGGANTIAN_KTM, Client.mahasiswa, form, REQUEST_STATUS.Mulai);
        }
        public static async Task uploadRequestAsync(Object product)
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.PostAsJsonAsync("http://localhost:5299/api/Request", product);
            response.EnsureSuccessStatusCode();
        }
    }
}
