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
    public partial class KulPukaRug : Form
    {
        public KulPukaRug()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FarmerWindows fw = new FarmerWindows();
            this.Hide();
            fw.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FarmerHomePage fhp = new FarmerHomePage();
            this.Hide();
            fhp.Show();
        }
    }
}
