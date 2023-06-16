using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKTMserviceWindows
{
    public class ControllerMainMenu
    {
        // Deklarasi laman main menu.
        private MainMenu _mainMenu;

        // Atribut yang menyimpan semua filepath banner.
        private Banner _bannerImages;
        private int _bannerNow;

        // Constructor assign main menu.
        public ControllerMainMenu(MainMenu mainMenu)
        {
            _mainMenu = mainMenu;
            _bannerImages = new Banner();
            _bannerNow = 0;
            PictureBox pb = _mainMenu.getPictureBox1();
            pb.ImageLocation = _bannerImages.showBanner(Banner.banner.PenggunaanWebsite);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void ChangeImageRight()
        {
            if (_bannerNow > 0 && _bannerNow < 3)
            {
                _bannerNow++;
                PictureBox pb = _mainMenu.getPictureBox1();
                if (_bannerNow == 1)
                {  
                    pb.ImageLocation = _bannerImages.showBanner(Banner.banner.PerbaikanKTM);
                } else if (_bannerNow == 2)
                {
                    pb.ImageLocation = _bannerImages.showBanner(Banner.banner.PenggantianKTM);
                }
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            
        }
    }
}
