namespace DBServerAPI
{
    public class Banner
    {
        //table-driven method
        public enum banner
        {
            PenggunaanWebsite,
            PerbaikanKTM,
            PenggantianKTM
        } 

        public void showBanner(banner x)
        {
            //Menampilkan image sesuai dengan input parameter
            String[] imageBanner = { "imagePenggunaanWebsite.jpg", "imagePerbaikanKTM.jpg", "imagePenggantianKTM.jpg" };
            Console.WriteLine(imageBanner[(int)x]);
        }
    }
}
