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
        public login()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            home log = new home();
            log.Show();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            signup sign = new signup();
            sign.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            signup sign = new signup();
            sign.Show();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
