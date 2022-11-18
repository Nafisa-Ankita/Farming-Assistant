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
    
    public partial class SellPage : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["signupPage"].ConnectionString;

        public SellPage()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Image";
            openFileDialog.Filter = "Image File (All Files) *.* | *.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool isNullOrEmpty = pictureBox1 == null || pictureBox1.Image == null;
            if (textBox1.Text != "")
            {
                if (!isNullOrEmpty)
                {
                    SqlConnection con = new SqlConnection(cs);
                    string query = "INSERT INTO sell_product VALUES (@title,@img,@price)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@title", textBox1.Text);
                    cmd.Parameters.AddWithValue("@img", SavePhoto());
                    cmd.Parameters.AddWithValue("@price", numericUpDown1.Value);

                    con.Open();
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Data Inserted Successfull", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Data Insertion Failed!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please insert your problem picture", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("please write your product title.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private byte[] SavePhoto()
        {
            MemoryStream memoryStream = new MemoryStream();
            pictureBox1.Image.Save(memoryStream, pictureBox1.Image.RawFormat);
            return memoryStream.GetBuffer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FarmerHomePage fhp = new FarmerHomePage();
            this.Hide();
            fhp.Show();
        }
    }
}
