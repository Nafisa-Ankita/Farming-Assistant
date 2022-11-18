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

namespace SignUpWithLogin
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string signupCs = ConfigurationManager.ConnectionStrings["signupPage"].ConnectionString;
            SqlConnection signupCon = new SqlConnection(signupCs);

            string signupQuery2 = "select * from signup where username=@username and pass=@pass";
            SqlCommand signupCmd2 = new SqlCommand(signupQuery2, signupCon);
            signupCmd2.Parameters.AddWithValue("@username", textBox1.Text);
            signupCmd2.Parameters.AddWithValue("@pass", textBox2.Text);

            

            signupCon.Open();

            SqlDataReader rd = signupCmd2.ExecuteReader();
            if (rd.HasRows == true)
            {
                MessageBox.Show("Login Successfully !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FarmerHomePage fhm = new FarmerHomePage();
                this.Hide();
                fhm.Show();
            }
            else
            {
                MessageBox.Show("Login Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            signupCon.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SIGNUP su = new SIGNUP();
            su.Show();
            this.Hide();            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool check = checkBox1.Checked;

            switch (check)
            {
                case true:
                    textBox2.UseSystemPasswordChar = false;
                    break;
                default:
                    textBox2.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
