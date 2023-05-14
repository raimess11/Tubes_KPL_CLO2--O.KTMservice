namespace DBServerAPI
{
    public class Banner
    {
        public enum banner
        {
            PenggunaanWebsite,
            PerbaikanKTM,
            PenggantianKTM
        } 

        public void showBanner(banner x)
        {
            String[] imageBanner = { "image1.jpg", "image2.jpg", "image3.jpg" };
            Console.WriteLine(imageBanner[(int)x]);
        }
    }
}
