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
    public partial class Author : Form
    {
        Controller c;
        Publisher P;
        string us;
        string ispn;
        int Aid;
        public Author()
        {
            
            c = new Controller();
            InitializeComponent();
        }
        public Author(string s1,string s2)
        {
            c = new Controller();
            InitializeComponent();
            us = s1;
            ispn = s2;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            c.InsertAuthor(AAFN.Text, AALN.Text, Aid, dateTimePicker1.Text, AACOB.Text, AAN.Text, AAA.Text);
            if (P == null)
            {
                P = new Publisher(us,ispn,Aid);
                P.Show();
            }
            else
            {
                P.Show();
                P.Focus();
            }
           
            
        }
    }
}
