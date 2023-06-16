using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OKTMserviceWindows
{
    public partial class MainMenu : Form
    {
        // Controller yang memproses inputan.
        private ControllerMainMenu _ck;

        public MainMenu()
        {
            InitializeComponent();
            _ck = new ControllerMainMenu(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
