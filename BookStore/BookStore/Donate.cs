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
        string name;
        public bool ds;
        public Donate()
        {
            
            c = new Controller();
            InitializeComponent();
        }
        public Donate(string n)
        {
            name = n;
            c = new Controller();
            InitializeComponent();
            ds = true;
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
                a = new Author(name, DISPN.Text);
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
                c.InsertBookToDonate(DISPN.Text, DBT.Text, DBookCategory.Text,dp, v2, v4, DBookLanguage.Text, v3,DIatB.Text, Convert.ToDateTime(DPD.Text), name);
                ds = true;
            }
        }

        private void UploadBookCover_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Images|*.jpg;*.png;*.gif;*.bmp";
            of.InitialDirectory = "C:\\";
            of.FilterIndex = 1;
            if (of.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (of.CheckFileExists)
                {
                    dp = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
                    string cfn = System.IO.Path.GetFileName(of.FileName) ;
                    System.IO.File.Copy(of.FileName, dp + "\\img\\" + cfn + DBT.Text);
                    DpictureBox1.Image = Image.FromFile(of.FileName);
                    MessageBox.Show("succefully uploaded");
                    dp = "\\img\\" + cfn + DBT.Text;
                }

            }
        }
    }
}
