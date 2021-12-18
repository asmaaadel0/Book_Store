using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BookStore
{
    public partial class signup : Form
    {
        private Button currentbutton;
        private Random random;
        private int tempIndex;
        Controller controllerObj;
        public signup()
        {
            InitializeComponent();
        }
        private void signup_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
        }        
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public bool isusername(string username)
        {
            DataTable dt = controllerObj.usernames();
            bool exists = false;
            foreach (DataRow row in dt.Rows)
            {
                if (row["username"].ToString().ToLower().Trim() == username)
                {
                    exists = true;
                }
            }
            return exists;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (firstnametextBox.Text == "")
            {
                MessageBox.Show("Fill out first name to sign up ");
                return;
            }
            if(lastnametextBox.Text == "")
            {
                MessageBox.Show("Fill out last name to sign up ");
                return;
            }
            if(emailtextBox.Text == "")
            {
                MessageBox.Show("Fill out email to sign up ");
                return;
            }
            if (passwordtextBox.Text == "")
            {
                MessageBox.Show("Fill out password to sign up ");
                return;
            }
            if (isusername(usernametextBox.Text))
            {
                MessageBox.Show("this username is invalid");
                return;
            }
            int result = controllerObj.signupform(firstnametextBox.Text, lastnametextBox.Text, usernametextBox.Text, passwordtextBox.Text, emailtextBox.Text,statetextBox.Text, citytextBox.Text, districttextBox.Text, streettextBox.Text, Int16.Parse(housenumbertextBox.Text),postalnumbertextBox.Text, countrycodetextBox.Text, phonenumbertextBox.Text);
            if (result == 0)
            {
                MessageBox.Show("The sign up failed");
            }
            else
            {
                MessageBox.Show("you signed up successfully!");
            }
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void housenumbertextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void housenumbertextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
