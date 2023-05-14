using DBServerAPI;
using MenyantumkanDokumen;

namespace O.KTMservice
{

    
    public class Program
    {
        static void Main(string[] args)
        {
            
            Form form = new Form();

            form.showForm("PENGGANTIAN_KTM");

            Console.WriteLine(form.files["KSM"]);
        }
    }
}