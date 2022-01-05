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
        Controller c;
        Author a ;
        string Lp;
      public  bool ls;
        public Lend()
        {
            
            c = new Controller();
            InitializeComponent();
        }

        private void LInsertAuthorInformation_Click(object sender, EventArgs e)
        {
            
            if (a == null)
            {
                a = new Author(LUserName.Text, LISPN.Text);
                a.Show();
            }
            else
            {
                a.Show();
                a.Focus();
            }
            int v1, v2, v3, v4;
            bool f1 = int.TryParse(LLendingPeriod.Text, out v1);
            bool f2 = int.TryParse(LNoB.Text, out v2);
            bool f3 = int.TryParse(LNoE.Text, out v3);
            bool f4 = int.TryParse(LNoBP.Text, out v4);
            if (f2 && f3 && f4)
            {
                c.InsertBookToLend(LISPN.Text, LBT.Text, LBookCategory.Text, Lp, v2, v4, LBookLanguage.Text, v3, LIatB.Text, LPD.Text, LUserName.Text,v1);
                ls = true;
            }
        }

        private void UploadBookCover_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Images|*.jpg;*.png;*.gif;*.bmp";
            of.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (of.ShowDialog() == DialogResult.OK)
            {
                LpictureBox1.Image = Image.FromFile(of.FileName);
                Lp = Application.StartupPath;
            }
        }
    }
}
