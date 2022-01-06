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
      string name;
        public Lend()
        {
            
            c = new Controller();
            InitializeComponent();
        }
        public Lend(string n)
        {
            name = n;
            c = new Controller();
            InitializeComponent();
            ls = true;
        }

        private void LInsertAuthorInformation_Click(object sender, EventArgs e)
        {
            
            if (a == null)
            {
                a = new Author(name, LISPN.Text);
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
                c.InsertBookToLend(LISPN.Text, LBT.Text, LBookCategory.Text, Lp, v2, v4, LBookLanguage.Text, v3, LIatB.Text,Convert.ToDateTime( LPD.Text), name,v1);
                ls = true;
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
                    Lp = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
                    string cfn = System.IO.Path.GetFileName(of.FileName) ;
                    System.IO.File.Copy(of.FileName, Lp +"\\img\\" + cfn + LBT.Text);
                    LpictureBox1.Image = Image.FromFile(of.FileName);
                    MessageBox.Show("succefully uploaded");
                    Lp = Lp + "\\img\\" + cfn + LBT.Text;
                }

            }
        }
    }
}
