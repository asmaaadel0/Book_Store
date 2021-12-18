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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginlogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login log = new login();
            log.Show();
        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel21_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void logo_Paint(object sender, PaintEventArgs e)
        {

        }
        private void loginbutton_Click(object sender, EventArgs e)
        {
            if (firstnametextBox.Text == "First Name" || lastnametextBox.Text == "Last Name")
            {
                panel30.Visible = true;
                return;
            }
            if (isusername(usernametextbox.Text))
            {
                panel5.Visible = true;
                return;
            }
            if (emailtextBox.Text == "E-mail")
            {
                panel10.Visible = true;
                return;
            }
            if (passwordtextBox.Text == "Password")
            {
                panel8.Visible = true;
                return;
            }
            int result = controllerObj.signupform(firstnametextBox.Text, lastnametextBox.Text, usernametextbox.Text, passwordtextBox.Text, emailtextBox.Text, statetextBox.Text, citytextBox.Text, districttextBox.Text, streettextBox.Text, Int16.Parse(housenumbertextBox.Text), postalnumbertextBox.Text, countrycodetextBox.Text, phonenumbertextBox.Text);
            if (result == 0)
            {
                MessageBox.Show("The sign up failed");
            }
            else
            {
                MessageBox.Show("you signed up successfully!");
            }
        }

        private void emailtextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (emailtextBox.Text == "")
                {
                    emailtextBox.Text = "E-mail";
                    emailtextBox.ForeColor = Color.Gray;
                    return;
                }
                emailtextBox.ForeColor = Color.White;
                panel10.Visible = false;
            }
            catch { }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel31_Paint(object sender, PaintEventArgs e)
        {

        }

        private void firstnametextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (firstnametextBox.Text == "")
                {
                    firstnametextBox.Text = "First Name";
                    firstnametextBox.ForeColor = Color.Gray;
                    return;
                }
                firstnametextBox.ForeColor = Color.White;
                panel30.Visible = false;
            }
            catch { }
        }

        private void firstnametextBox_Click(object sender, EventArgs e)
        {
            firstnametextBox.SelectAll();
        }

        private void lastnametextBox_Click(object sender, EventArgs e)
        {
            lastnametextBox.SelectAll();
        }

        private void usernametextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernametextbox_Click(object sender, EventArgs e)
        {
            usernametextbox.SelectAll();
        }

        private void emailtextBox_Click(object sender, EventArgs e)
        {
            emailtextBox.SelectAll();
        }

        private void passwordtextBox_Click(object sender, EventArgs e)
        {
            passwordtextBox.SelectAll();
        }

        private void postalnumbertextBox_Click(object sender, EventArgs e)
        {
            postalnumbertextBox.SelectAll();
        }

        private void countrycodetextBox_Click(object sender, EventArgs e)
        {
            countrycodetextBox.SelectAll();
        }

        private void phonenumbertextBox_TextChanged(object sender, EventArgs e)
        {
            phonenumbertextBox.ForeColor = Color.White;
        }

        private void statetextBox_TextChanged(object sender, EventArgs e)
        {
            statetextBox.ForeColor = Color.White;
        }

        private void citytextBox_TextChanged(object sender, EventArgs e)
        {
            citytextBox.ForeColor = Color.White;
        }

        private void citytextBox_Click(object sender, EventArgs e)
        {
            citytextBox.SelectAll();
        }

        private void streettextBox_Click(object sender, EventArgs e)
        {
            streettextBox.SelectAll();
        }

        private void districttextBox_Click(object sender, EventArgs e)
        {
            districttextBox.SelectAll();
        }

        private void housenumbertextBox_Click(object sender, EventArgs e)
        {
            housenumbertextBox.SelectAll();
        }

        private void phonenumbertextBox_Click(object sender, EventArgs e)
        {
            phonenumbertextBox.SelectAll();
        }

        private void statetextBox_Click(object sender, EventArgs e)
        {
            statetextBox.SelectAll();
        }

        private void lastnametextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (lastnametextBox.Text == "")
                {
                    lastnametextBox.Text = "Last Name";
                    lastnametextBox.ForeColor = Color.Gray;
                    return;
                }
                lastnametextBox.ForeColor = Color.White;
                panel30.Visible = false;
            }
            catch { }
        }

        private void usernametextbox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (usernametextbox.Text == "")
                {
                    usernametextbox.Text = "Enter User name";
                    usernametextbox.ForeColor = Color.Gray;
                    return;
                }
                usernametextbox.ForeColor = Color.White;
                panel5.Visible = false;
            }
            catch { }
        }

        private void passwordtextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (passwordtextBox.Text == "")
                {
                    passwordtextBox.Text = "Password";
                    passwordtextBox.ForeColor = Color.Gray;
                    return;
                }
                passwordtextBox.ForeColor = Color.White;
                panel8.Visible = false;
            }
            catch { }
        }

        private void usernametextbox_Click_1(object sender, EventArgs e)
        {
            usernametextbox.SelectAll();
        }

        private void postalnumbertextBox_TextChanged(object sender, EventArgs e)
        {
            postalnumbertextBox.ForeColor = Color.White;
        }

        private void countrycodetextBox_TextChanged(object sender, EventArgs e)
        {
            countrycodetextBox.ForeColor = Color.White;
        }

        private void streettextBox_TextChanged(object sender, EventArgs e)
        {
            streettextBox.ForeColor = Color.White;
        }

        private void districttextBox_TextChanged(object sender, EventArgs e)
        {
            districttextBox.ForeColor = Color.White;
        }

        private void housenumbertextBox_TextChanged_1(object sender, EventArgs e)
        {
            housenumbertextBox.ForeColor = Color.White;
        }

        private void phonenumbertextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void housenumbertextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void postalnumbertextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
