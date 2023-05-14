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
            //i.s. Terdapat parameter x sebagai indeks untuk enum banner
            //f.s. Menampilkan imageBanner indeks yang sesuai dengan parameter
            string[] imageBanner = { "imagePenggunaanWebsite.jpg", "imagePerbaikanKTM.jpg", "imagePenggantianKTM.jpg" };
            Console.WriteLine(imageBanner[(int)x]);
        }
    }
}
