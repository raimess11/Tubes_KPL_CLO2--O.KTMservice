using DBServerAPI;
using O.KTMservice;

namespace OKTMserviceWindows
{
    public partial class Login : DBServerAPI.Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void Login_Load(object sender, EventArgs e)
        {
            LoginController1.UserLogin();
        }

        private void textBox_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = "user";
            string password = "12345678";

            if (textBox_username.Text == username && textBox_password.Text == password)
            {

                MessageBox.Show("Login successful!");
            }
        }

        private void pictureBox_penggunaanWebsite_Click(object sender, EventArgs e)
        {
            // Membuat instance dari model Banner
            Banner banner = new Banner();

            // Menampilkan banner PenggunaanWebsite
            banner.showBanner(Banner.banner.PenggunaanWebsite);
            banner.showBanner(Banner.banner.PerbaikanKTM);
            banner.showBanner(Banner.banner.PenggantianKTM);
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
            {
                textBox_password.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_password.UseSystemPasswordChar = true;
            }
        }
    }
}
