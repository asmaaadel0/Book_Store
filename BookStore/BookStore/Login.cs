using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class login : Form
    {
        Controller controllerObj;
        public login()
        {
            InitializeComponent();
        }
        private void loginbutton_Click(object sender, EventArgs e)
        {

        }
        private void login_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginlogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void usernametextbox_TextChanged(object sender, EventArgs e)
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
                passwordtextBox.ForeColor = Color.White;
                passwordtextBox.PasswordChar = '*';
                panel7.Visible = false;
            }
            catch { }
        }

        private void usernametextbox_Click(object sender, EventArgs e)
        {
            usernametextbox.SelectAll();
        }

        private void passwordtextBox_Click(object sender, EventArgs e)
        {
            passwordtextBox.SelectAll();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void loginbutton_MouseLeave(object sender, EventArgs e)
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
        public bool rightpassword(string username,string password)
        {
            string pass = controllerObj.passwordofusername(username);
            if (pass == password)
                return true;
            else
                return false;
        }
        private void loginbutton_Click_1(object sender, EventArgs e)
        {
            if (usernametextbox.Text == "Enter User name" || !isusername(usernametextbox.Text))
            {
                panel5.Visible = true;
                usernametextbox.Focus();
                return;
            }
            if (passwordtextBox.Text == "Password" ||passwordtextBox.Text==""|| !rightpassword(usernametextbox.Text,passwordtextBox.Text))
            {
                panel7.Visible = true;
                passwordtextBox.Focus();
                return;
            }
            Form1 home = new Form1();
            home.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signup sign = new signup();
            sign.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
