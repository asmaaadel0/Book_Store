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
    public partial class sell : Form
    {
        Controller c;
        string p;
        Author a ;
        string name;
      public bool ss;
        public sell()
        {
            c=new Controller();
            InitializeComponent();
            ss = true;
        }
        public sell(string n)
        {
            name = n;
            c = new Controller();
            InitializeComponent();
            ss = true;
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (a == null)
            {
                a = new Author(name, SISPN.Text);
                a.Show();
            }
            else
            {
                a.Show();
                a.Focus();
            }
           int v1,v2,v3,v4;
           bool f1 = int.TryParse(SPoaB.Text,out v1);
           bool f2 = int.TryParse(SNumberofBooks.Text,out v2);
           bool f3 = int.TryParse(SNoE.Text, out v3);
           bool f4 = int.TryParse(SNumberofBookPages.Text,out v4);
           if (f1&&f2&&f3&&f4)
           {
               c.InsertBookToSell(SISPN.Text, SBookTitle.Text, SBookCategory.Text, p, v2, v4, SBookLanguage.Text, v3, SNatB.Text,Convert.ToDateTime( SPD.Text), name, v1);
              

           }
          
        }

        private void SUploadBookCover_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Images|*.jpg;*.png;*.gif;*.bmp";
            of.InitialDirectory ="C:\\";
            of.FilterIndex = 1;
            if (of.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (of.CheckFileExists)
                {
                    p = Application.StartupPath.Substring(0,Application.StartupPath.Length-10);
                    string cfn = System.IO.Path.GetFileName(of.FileName);
                    System.IO.File.Copy(of.FileName, p + "\\img\\" + cfn + SBookTitle.Text);
                    SpictureBox1.Image = Image.FromFile(of.FileName);
                    MessageBox.Show("succefully uploaded");
                    p = "\\img\\" + cfn + SBookTitle.Text;
                }
            
            }
            
        }

        private void SBookTitle_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
