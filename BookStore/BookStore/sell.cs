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
      public bool ss;
        public sell()
        {
            c=new Controller();
            InitializeComponent();
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
                a = new Author(SUserName.Text, SISPN.Text);
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
               c.InsertBookToSell(SISPN.Text, SBookTitle.Text, SBookCategory.Text, p, v2, v4, SBookLanguage.Text, v3, SNatB.Text, SPD.Text, SUserName.Text, v1);
               ss = true;
           }
          
        }

        private void SUploadBookCover_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Images|*.jpg;*.png;*.gif;*.bmp";
            of.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (of.ShowDialog() == DialogResult.OK)
            {
                p = Application.StartupPath;
                SpictureBox1.Image = Image.FromFile(of.FileName);
            }
            
        }

        private void SBookTitle_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
