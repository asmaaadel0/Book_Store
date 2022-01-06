using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace BookStore
{
    public partial class Publisher : Form
    {
        Controller c;
        string path;
        string pus;
        string pispn;
        int aid;
        sell s;
        Donate d;
        Lend l;
        PublisherAddress PA;
        public Publisher()
        {
            c = new Controller();
            InitializeComponent();
        }
        public Publisher(string s1, string s2,int id)
        {
            c = new Controller();
            InitializeComponent();
            pus = s1;
            pispn = s2;
            aid = id;
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void PIAI_Click(object sender, EventArgs e)
        {
            l = new Lend();
            d = new Donate();
            s = new sell();
           
            c.InsertPublisher( PPN.Text, PEmail.Text, PAP.Text, PFax.Text,path);
            DataTable dt = c.SelectPblisherID(PEmail.Text);
            DataRow r = dt.Rows[0];
            int pid = (int)r["Publisher_ID"];
            
            if (s.ss)
            {
                c.Updatebooktosell(pid, pus, pispn, aid);
            }
            if (l.ls)
            {
                c.Updatebooktolend(pid, pus, pispn, aid);
            }
            if (d.ds)
            {
                c.Updatebooktodonate(pid, pus, pispn, aid);
            }
            if (PA == null)
            {
                PA = new PublisherAddress(pid);
                PA.Show();
            }
            else
            {
                PA.Show();
                PA.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Images|*.jpg;*.png;*.gif;*.bmp";
            of.InitialDirectory = "C:\\";
            if (of.ShowDialog() == DialogResult.OK)
            {
                path = Application.StartupPath;
                pictureBox1.Image = Image.FromFile(of.FileName);
            }
        }
    }
}
