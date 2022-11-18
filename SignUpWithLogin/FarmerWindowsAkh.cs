using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignUpWithLogin
{
    public partial class FarmerWindowsAkh : Form
    {
        public FarmerWindowsAkh()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FarmerWindows fw = new FarmerWindows();
            this.Hide();
            fw.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Akh1 a = new Akh1();
            this.Hide();
            a.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Akh2 a = new Akh2();
            this.Hide();
            a.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Akh3 a = new Akh3();
            this.Hide();
            a.Show();
        }
    }
}
