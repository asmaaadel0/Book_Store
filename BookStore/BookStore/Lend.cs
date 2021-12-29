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
    public partial class Lend : Form
    {
        Author a = new Author();
        public Lend()
        {
            InitializeComponent();
        }

        private void LInsertAuthorInformation_Click(object sender, EventArgs e)
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

        private void UploadBookCover_Click(object sender, EventArgs e)
        {

        }
    }
}
