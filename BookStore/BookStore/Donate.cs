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
    public partial class Donate : Form
    {
        Author a = new Author();
        public Donate()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NumberofBookPages_Click(object sender, EventArgs e)
        {

        }

        private void DInsertAuthorInformation_Click(object sender, EventArgs e)
        {
           
            if (a == null)
            {
                a = new Author();
                a.Show();
            }
            else
            {
                a.Show();
                a.Focus();
            }
        }
    }
}
