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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void home_Load(object sender, EventArgs e)
        {

        }

        private void login_Click_1(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            signup sign = new signup();
            sign.Show();
            this.Hide();
        }

        private void loginadmin_Click(object sender, EventArgs e)
        {

        }
    }
}
