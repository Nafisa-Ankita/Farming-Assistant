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
    public partial class FarmerWindowsDhan : Form
    {
        public FarmerWindowsDhan()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DhanRug1 dr = new DhanRug1();
            this.Hide();
            dr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FarmerWindows fw = new FarmerWindows();
            this.Hide();
            fw.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PataBlastRug dr = new PataBlastRug();
            this.Hide();
            dr.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            KulPukaRug dr = new KulPukaRug();
            this.Hide();
            dr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FarmerHomePage fhp = new FarmerHomePage();
            this.Hide();
            fhp.Show();
        }
    }
}
