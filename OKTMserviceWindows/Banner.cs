namespace OKTMserviceWindows
{
    public class Banner
    {
        // Table-Driven method
        public enum banner
        {
            PenggunaanWebsite,
            PerbaikanKTM,
            PenggantianKTM
        }

        public string showBanner(banner x)
        {
            //i.s. Terdapat parameter x sebagai indeks untuk enum banner
            //f.s. Menampilkan imageBanner indeks yang sesuai dengan parameter
            string[] imageBanner = { "imagePenggunaanWebsite.jpg", "imagePerbaikanKTM.jpg", "imagePenggantianKTM.jpg" };
            return imageBanner[(int)x];
        }

        // Runtime Configuration
        // class untuk menampung configurasi
        public string PenggunaanWebsite { get; set; }
        public string PerbaikanKTM { get; set; }
        public string PenggantianKTM { get; set; }

        public Banner() { }

        public Banner(string penggunaanWebsite, string perbaikanKTM, string penggantianKTM)
        {
            PenggunaanWebsite = penggunaanWebsite;
            PerbaikanKTM = perbaikanKTM;
            PenggantianKTM = penggantianKTM;
        }
    }
}
