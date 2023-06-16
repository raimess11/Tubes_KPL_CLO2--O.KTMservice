using DBServerAPI;
using DBServerAPI.Controllers;
using MenyantumkanDokumen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKTMserviceWindows
{
    internal static class ControllerReqKTMBermasalah
    {
        //melakukan create request
        public static Request CreateRequest(SERVICE_TYPE type, Mahasiswa mahasiswa,String pathLampiran1, string deskripsi)
        {
            //Menyantumkan foto kedalam files
            CantumFoto.Foto fotoLampiran1 = CantumFoto.holdFotoAPI(pathLampiran1);

            DBServerAPI.Form form = new DBServerAPI.Form();
            form.files.Add("KTM", fotoLampiran1);
                
            //Return request
            return new Request(type, mahasiswa, form, REQUEST_STATUS.Mulai);
        }
        //upload request
        public static void UploadRequest(Request req)
        {
            //secure coding standard "Input Validation"
            if(req != null)
            {
                //Post to API
                RequestController Control = new RequestController();
                Control.Post(req);
            }
            else
            {
                //Breaker
                return;
            }
        }
     }
}
