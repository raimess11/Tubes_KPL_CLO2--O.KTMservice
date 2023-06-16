namespace DBServerAPI
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

        public void showBanner(banner index)
        {
            //i.s. Terdapat parameter x sebagai indeks untuk enum banner
            //f.s. Menampilkan imageBanner indeks yang sesuai dengan parameter
            string[] imageBanner = { "imagePenggunaanWebsite.jpg", "imagePerbaikanKTM.jpg", "imagePenggantianKTM.jpg" };
            Console.WriteLine(imageBanner[(int)index]);
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
