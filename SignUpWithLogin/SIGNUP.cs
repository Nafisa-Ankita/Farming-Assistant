using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Data.SqlClient;

namespace SignUpWithLogin
{
    public partial class SIGNUP : Form
    {
        string passPattern = @"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$";
        public SIGNUP()
        {
            InitializeComponent();
        }

        private void SIGNUP_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LOGIN LN = new LOGIN();
            LN.Show();
            this.Hide();
        }

        private void SignupMobileNO_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SignupMobileNO.Text) == true)
            {
                SignupMobileNO.Focus();
                errorProvider3.SetError(this.SignupMobileNO, "Please Fill The Mobile Number");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void SignupMobileNO_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch)==true)
            {
                e.Handled = false;
            }
            else if (ch==8)
            {
                e.Handled = false;
            }
            //else if (SignupMobileNO.TextLength > 12)
            //{
            //    e.Handled = true;
            //}
            else
            {
                e.Handled = true;
            }
        }

        

        private void SignupName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SignupName.Text) == true)
            {
                SignupName.Focus();
                errorProvider1.SetError(this.SignupName, "Please Fill The Name");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void SignupName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch) == true)
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else if (ch == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void SignupUserName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SignupUserName.Text) == true)
            {
                SignupUserName.Focus();
                errorProvider2.SetError(this.SignupUserName, "Please Fill The UserName");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void SignupUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;
            }
            else if (char.IsLetter(ch) == true)
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else if (ch == 32)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void SignupGender_Leave(object sender, EventArgs e)
        {
            if (SignupGender.SelectedItem==null)
            {
                SignupGender.Focus();
                errorProvider5.SetError(this.SignupGender, "Please selected Gender ");
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void SignupRole_Leave(object sender, EventArgs e)
        {
            if (SignupRole.SelectedItem == null)
            {
                SignupRole.Focus();
                errorProvider4.SetError(this.SignupRole, "Please selected ROLE ");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void SignupPassword_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(SignupPassword.Text, passPattern) == false)
            {
                SignupPassword.Focus();
                errorProvider6.SetError(this.SignupPassword, "UpperCase , LowerCase ,Number , Special Char");
            }
            else
            {
                errorProvider6.Clear();
            }
        }

        private void SignupConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (SignupPassword.Text != SignupConfirmPassword.Text)
            {
                SignupConfirmPassword.Focus();
                errorProvider7.SetError(this.SignupConfirmPassword, "Password is no Match");
            }
            else
            {
                errorProvider7.Clear();
            }
        }

        private void SignupSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SignupName.Text) == true)
            {
                SignupName.Focus();
                errorProvider1.SetError(this.SignupName, "Please Fill The Name");
            }
            else if (string.IsNullOrEmpty(SignupUserName.Text) == true)
            {
                SignupUserName.Focus();
                errorProvider2.SetError(this.SignupUserName, "Please Fill The UserName");
            }
            else if (string.IsNullOrEmpty(SignupMobileNO.Text) == true)
            {
                SignupMobileNO.Focus();
                errorProvider3.SetError(this.SignupMobileNO, "Please Fill The Mobile Number");
            }
            else if (SignupRole.SelectedItem == null)
            {
                SignupRole.Focus();
                errorProvider4.SetError(this.SignupRole, "Please selected ROLE ");
            }
            else if (SignupGender.SelectedItem == null)
            {
                SignupGender.Focus();
                errorProvider5.SetError(this.SignupGender, "Please selected Gender ");
            }
            else if (Regex.IsMatch(SignupPassword.Text, passPattern) == false)
            {
                SignupPassword.Focus();
                errorProvider6.SetError(this.SignupPassword, "UpperCase , LowerCase ,Number , Special Char");
            }
            else if (SignupPassword.Text != SignupConfirmPassword.Text)
            {
                SignupConfirmPassword.Focus();
                errorProvider7.SetError(this.SignupConfirmPassword, "Password is no Match");
            }
            else
            {
                string signupCs = ConfigurationManager.ConnectionStrings["signupPage"].ConnectionString;
                SqlConnection signupCon = new SqlConnection(signupCs);

                string signupQuery2 = "select * from signup where username=@username";
                SqlCommand signupCmd2 = new SqlCommand(signupQuery2,signupCon);
                signupCmd2.Parameters.AddWithValue("@username",SignupUserName.Text);
                signupCon.Open();
                SqlDataReader rd = signupCmd2.ExecuteReader();
                if (rd.HasRows == true)
                {
                    MessageBox.Show(SignupUserName.Text + " UserName Already Exit !!", "Failur ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    signupCon.Close();
                }
                else
                {
                    signupCon.Close();
                    string signupQuery = "insert into signup values (@name,@username,@mobilenumber,@userrole,@gender,@pass)";
                    SqlCommand signupCmd = new SqlCommand(signupQuery, signupCon);
                    signupCmd.Parameters.AddWithValue("@name", SignupName.Text);
                    signupCmd.Parameters.AddWithValue("@username", SignupUserName.Text);
                    signupCmd.Parameters.AddWithValue("@mobilenumber", SignupMobileNO.Text);
                    signupCmd.Parameters.AddWithValue("@userrole", SignupRole.SelectedItem);
                    signupCmd.Parameters.AddWithValue("@gender", SignupGender.SelectedItem);
                    signupCmd.Parameters.AddWithValue("@pass", SignupPassword.Text);

                    signupCon.Open();
                    int a = signupCmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Register Successfully !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show("Your User name is : "+SignupUserName.Text+"\n\n"+"Your Password is : "+SignupPassword.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        LOGIN ln = new LOGIN();
                        ln.Show();
                    }
                    else
                    {
                        MessageBox.Show("Register Failed !!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    signupCon.Close();
                }
                
            }
            
        }

        private void SignupReset_Click(object sender, EventArgs e)
        {
            SignupName.Clear();
            SignupUserName.Clear();
            SignupMobileNO.Clear();
            SignupPassword.Clear();
            SignupConfirmPassword.Clear();
            SignupGender.SelectedItem = null;
            SignupRole.SelectedItem = null;

        }

        private void SignupRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
