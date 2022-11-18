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
    public partial class Payment : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["signupPage"].ConnectionString;
        public Payment()
        {
            InitializeComponent();
            BindGridView();
        }
        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from buy_product";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;

            //IMAGE COLUMN
            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            dgv = (DataGridViewImageColumn)dataGridView1.Columns[3];
            dgv.ImageLayout = DataGridViewImageCellLayout.Zoom;
            
            //AUTOSIZE
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //IMAGEHEIGHT
            dataGridView1.RowTemplate.Height = 50;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true || radioButton2.Checked==true || radioButton3.Checked==true )
            {
                MessageBox.Show("Your order is confirm!");
            }
            else
            {
                errorProvider1.SetError(this.button1, "Select one of the payment method");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FarmerHomePage f = new FarmerHomePage();
            this.Hide();
            f.Show();
        }
    }
}
