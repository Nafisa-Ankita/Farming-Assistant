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
    public partial class Calculate : Form
    {
        public Calculate()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                comboBox1.Focus();
                errorProvider1.SetError(this.comboBox1, "Please Select the Season ");
            }
            else if (comboBox2.SelectedItem == null)
            {
                comboBox2.Focus();
                errorProvider2.SetError(this.comboBox2, "Please Select the Crops ");
            }
            else if (string.IsNullOrEmpty(textBox3.Text) == true)
            {
                textBox3.Focus();
                errorProvider3.SetError(this.textBox3, "Please Fill The Mobile Number");
            }
            else {
                double txt1 = Convert.ToDouble(textBox3.Text);

                Random rd = new Random();

                int rand_num = rd.Next(50,100);
                double result = txt1 * rand_num;
                string s = " ";
                string t = " Taka";

                textBox4.Text = result.ToString() + s + t;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                comboBox1.Focus();
                errorProvider1.SetError(this.comboBox1, "Please Select the Season ");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == null)
            {
                comboBox2.Focus();
                errorProvider2.SetError(this.comboBox2, "Please Select the Crops ");
            }
            else
            {
                errorProvider2.Clear();
            }

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text) == true)
            {
                textBox3.Focus();
                errorProvider3.SetError(this.textBox3, "Please Fill The Mobile Number");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FarmerHomePage fhp = new FarmerHomePage();
            this.Hide();
            fhp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FarmerWindows fw = new FarmerWindows();
            this.Hide();
            fw.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FarmerPage fp = new FarmerPage();
            this.Hide();
            fp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LOGIN ln = new LOGIN();
            this.Hide();
            ln.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SellPage sp = new SellPage();
            this.Hide();
            sp.Show();
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

        private void button9_Click(object sender, EventArgs e)
        {
            BuyPage bp = new BuyPage();
            this.Hide();
            bp.Show();
        }
    }
}
