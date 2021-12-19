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
    public partial class LoginAdmin : Form
    {
        Controller controllerObj;
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void loginlogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginAdmin_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
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

        public bool isusernameadmin(string username)
        {
            DataTable dt = controllerObj.usernameadmin();
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
        public bool rightpasswordadmin(string username, string password)
        {
            string pass = controllerObj.passwordofusernameadmin(username);
            if (pass == password)
                return true;
            else
                return false;
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            if (usernametextbox.Text == "Enter User name" || !isusernameadmin(usernametextbox.Text))
            {
                panel5.Visible = true;
                usernametextbox.Focus();
                return;
            }
            if (passwordtextBox.Text == "Password" || passwordtextBox.Text == "" || !rightpasswordadmin(usernametextbox.Text, passwordtextBox.Text))
            {
                panel7.Visible = true;
                passwordtextBox.Focus();
                return;
            }
        }

        private void usernametextbox_Click(object sender, EventArgs e)
        {
            usernametextbox.SelectAll();
        }

        private void passwordtextBox_Click(object sender, EventArgs e)
        {
            passwordtextBox.SelectAll();
        }

        private void passwordtextBox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                passwordtextBox.ForeColor = Color.White;
                passwordtextBox.PasswordChar = '*';
                panel7.Visible = false;
            }
            catch { }
        }
    }
}
