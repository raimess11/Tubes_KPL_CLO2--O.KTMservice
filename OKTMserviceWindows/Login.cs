using DBServerAPI;
using O.KTMservice;

namespace OKTMserviceWindows
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();

            this.Text = "Login";
            
        }


        private void Login_Load(object sender, EventArgs e)
        {
            LoginController.UserLogin();
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
                this.Hide();
                MessageBox.Show("Login successful!");
            }

            LoginController.UserLogin();
        }

        private void pictureBox_penggunaanWebsite_Click(object sender, EventArgs e)
        {
            // Membuat instance dari model Banner
            Banner banner = new Banner();

            // Menampilkan banner PenggunaanWebsite
            banner.showBanner(Banner.banner.PenggunaanWebsite);
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked == true)
            {
                textBox_password.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_password.UseSystemPasswordChar = true;
            }
        }

        private void btn_ToLeft_Click(object sender, EventArgs e)
        {

        }

        private void btn_ToRight_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load_1(object sender, EventArgs e)
        {
            LoginController.UserLogin();
        }
    }
}