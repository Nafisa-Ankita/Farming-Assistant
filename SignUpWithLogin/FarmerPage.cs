using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace SignUpWithLogin
{
    public partial class FarmerPage : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["signupPage"].ConnectionString;
        //problem solve it

        public FarmerPage()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Image";
            openFileDialog.Filter = "Image File (All Files) *.* | *.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool isNullOrEmpty = pictureBox2 == null || pictureBox2.Image == null;
            if (textBox1.Text != "")
            {
                if (!isNullOrEmpty)
                {
                    SqlConnection con = new SqlConnection(cs);
                    string query = "INSERT INTO farmer_dash VALUES (@title,@img)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@title", textBox1.Text);
                    cmd.Parameters.AddWithValue("@img", SavePhoto());

                    con.Open();
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Data Inserted Successfull","Successfull",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Data Insertion Failed!","Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Please insert your problem picture", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("please write your problem title.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private byte[] SavePhoto()
        {
            MemoryStream memoryStream = new MemoryStream();
            pictureBox2.Image.Save(memoryStream, pictureBox2.Image.RawFormat);
            return memoryStream.GetBuffer();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                textBox1.Text = "";
            }
            if(pictureBox2 != null)
            {
                pictureBox2.Image = null;
            }
            else
            {
                MessageBox.Show("Nothing to reset","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            FarmerHomePage fhp = new FarmerHomePage();
            this.Hide();
            fhp.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FarmerWindows fw = new FarmerWindows();
            this.Hide();
            fw.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Calculate c = new Calculate();
            this.Hide();
            c.Show();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button7_Click(object sender, EventArgs e)
        {
            ContactUs cu = new ContactUs();
            this.Hide();
            cu.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            About a = new About();
            this.Hide();
            a.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            BuyPage bp = new BuyPage();
            this.Hide();
            bp.Show();
        }
    }
}
