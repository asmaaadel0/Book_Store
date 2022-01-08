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
    public partial class PublisherAddress : Form
    {
        
        Controller c;
        int id;
        public PublisherAddress(int pid)
        {
            c = new Controller();
            InitializeComponent();
            id = pid;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Add(PS.Text, PD.Text, PC.Text, PST.Text, PH.Text);
          
            int v;
            bool f = int.TryParse(PH.Text,out v);
            if (f)
               c.InsertPublisherAddress(id, PS.Text, PD.Text, PC.Text, PST.Text,v);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
       {

        }

        private void PublisherAddress_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(PCC.Text, PPN.Text);
            c.InsertPublisherPhoneNumber(id, PCC.Text, PPN.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
   }
}
