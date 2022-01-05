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
        Controller c;
        Author a ;
        string dp;
        public bool ds;
        public Donate()
        {
           
            c = new Controller();
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
                a = new Author(DNU.Text, DISPN.Text);
                a.Show();
            }
            else
            {
                a.Show();
                a.Focus();
            }
            int v2, v3, v4;
           
            bool f2 = int.TryParse(DNoB.Text, out v2);
            bool f3 = int.TryParse(DNoE.Text, out v3);
            bool f4 = int.TryParse(DNoBP.Text, out v4);
            if (f2 && f3 && f4)
            {
                c.InsertBookToDonate(DISPN.Text, DBT.Text, DBookCategory.Text,dp, v2, v4, DBookLanguage.Text, v3,DIatB.Text, DPD.Text, DNU.Text);
                ds = true;
            }
        }

        private void UploadBookCover_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Images|*.jpg;*.png;*.gif;*.bmp";
            of.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (of.ShowDialog() == DialogResult.OK)
            {
                dp = Application.StartupPath;
                DpictureBox1.Image = Image.FromFile(of.FileName);
            }
        }
    }
}
