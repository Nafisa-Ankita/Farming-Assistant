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
    public partial class FarmerHomePage : Form
    {
        public FarmerHomePage()
        {
            InitializeComponent();
        }

        private void FarmerHomePage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FarmerHomePage fhp = new FarmerHomePage();
            this.Hide();
            fhp.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            SellPage sp = new SellPage();
            this.Hide();
            sp.Show();
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    FarmerWindows fw = new FarmerWindows();
        //    this.Hide();
        //    fw.Show();
        //}

        //private void button6_Click(object sender, EventArgs e)
        //{
        //    FarmerPage fp = new FarmerPage();
        //    this.Hide();
        //    fp.Show();
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    Calculate c = new Calculate();
        //    this.Hide();
        //    c.Show();
        //}

        //private void button5_Click(object sender, EventArgs e)
        //{
        //    LOGIN ln = new LOGIN();
        //    this.Hide();
        //    ln.Show();
        //}

        //private void button7_Click(object sender, EventArgs e)
        //{

        //}

        //private void button4_Click(object sender, EventArgs e)
        //{

        //}

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FarmerWindows fw = new FarmerWindows();
            this.Hide();
            fw.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            FarmerPage fp = new FarmerPage();
            this.Hide();
            fp.Show();
        }

        
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    FarmerHomePage fhp = new FarmerHomePage();
        //    this.Hide();
        //    fhp.Show();
        //}

        private void button6_Click(object sender, EventArgs e)
        {
            FarmerPage fp = new FarmerPage();
            this.Hide();
            fp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculate c = new Calculate();
            this.Hide();
            c.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LOGIN ln = new LOGIN();
            this.Hide();
            ln.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FarmerWindows f = new FarmerWindows();
            this.Hide();
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SellPage s = new SellPage();
            this.Hide();
            s.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FarmerWindows f = new FarmerWindows();
            this.Hide();
            f.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            FarmerPage fp = new FarmerPage();
            this.Hide();
            fp.Show();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            SellPage sp = new SellPage();
            this.Hide();
            sp.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 bp = new Form1();
            this.Hide();
            bp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            About a = new About();
            this.Hide();
            a.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ContactUs cu = new ContactUs();
            this.Hide();
            cu.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            LOGIN ln = new LOGIN();
            this.Hide();
            ln.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Calculate c = new Calculate();
            this.Hide();
            c.Show();
        }
    }
}

