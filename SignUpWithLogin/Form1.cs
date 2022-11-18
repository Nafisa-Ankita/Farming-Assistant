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
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["signupPage"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            ofd.Filter = "Image file (*.png; *jpg) | *.png; *.jpg";
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into buy_product values(@id, @name, @price, @photo)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id",textBox2.Text);
            cmd.Parameters.AddWithValue("@name",textBox1.Text);
            cmd.Parameters.AddWithValue("@price",numericUpDown1.Value);
            cmd.Parameters.AddWithValue("@photo",SavePhoto());

            con.Open();
            int a = cmd.ExecuteNonQuery();//0 1
            if(a>0)
            {
                MessageBox.Show("Product added to the cart!");
                ResetControl(); 
            }
            else
            {
                MessageBox.Show("Products are not added");
            }
        }

        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            return ms.GetBuffer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Payment p = new Payment();
            this.Hide();
            p.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResetControl();
        }

        void ResetControl()
        {
            textBox1.Clear();
            textBox2.Clear();
            numericUpDown1.Value = 0;
            //pictureBox1.Image = Properties.Resources.Blank_image;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FarmerHomePage h = new FarmerHomePage();
            this.Hide();
            h.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            LOGIN ln = new LOGIN();
            this.Hide();
            ln.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
