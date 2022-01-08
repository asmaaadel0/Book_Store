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
    public partial class BuyAbook : Form
    {
        Controller controllerObj;
        DataTable dtOriginal;
        string ID="";
        string username;
        string BookSeller;
        String ISBN;
        int ChosenCount;
        int price;
        int period;    
        public BuyAbook(string name, string Seller , string ISN)
        {
            InitializeComponent();
            controllerObj = new Controller();
            username = name;
            ISBN = ISN;
            BookSeller = Seller;
            DataTable dt = controllerObj.CompanyCity();
            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "Destination";
            comboBox1.DisplayMember = "Destination";

            
            comboBox1.DataSource = dt;
            dataGridView1.Visible = false;

            DataTable dtCount = controllerObj.SelectBuyCountD(ISN, Seller);
            string count = dtCount.Rows[0][0].ToString();
            int cnt=0;
            Int32.TryParse(count, out cnt);
            for (int j = cnt; j > 0; j--)
            {
                comboBox2.Items.Add(j);
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {  
             var senderGrid = (DataGridView)sender;
             if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                 e.RowIndex >= 0)
             {
                 
                 ID = dtOriginal.Rows[e.RowIndex][3].ToString();
                 string Sprice = dtOriginal.Rows[e.RowIndex][2].ToString();
                 string Speriod = dtOriginal.Rows[e.RowIndex][2].ToString();
                 Int32.TryParse(Sprice, out price);
                 Int32.TryParse(Speriod, out period);
             }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex == -1)
            {
                panel5.Visible = true;
            }
            else
            {
                panel5.Visible = false;
                dataGridView1.Visible = true;
                label1.Visible = true;
                
                DataTable dt = controllerObj.SelectCompanyCity(comboBox1.Text);
                dt.Columns.Remove(dt.Columns[3]);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                dtOriginal = controllerObj.SelectCompanyCity(comboBox1.Text);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(this.comboBox2.SelectedIndex == -1)
                panel4.Visible = true;
            else
            {
                int result;
                panel4.Visible = false;
                Int32.TryParse(comboBox2.Text, out ChosenCount);
                if (ID=="")
                {
                    result=controllerObj.InsertBuyNoShipping(ISBN, BookSeller, username, ChosenCount);
                }
                else
                {
                    result=controllerObj.InsertBuyShipping(ISBN, BookSeller, username, ID, price, period, ChosenCount);
                }
                if (result != 0)
                {
                    controllerObj.decCountSell(ChosenCount, BookSeller, ISBN);
                    MessageBox.Show("Done Successfully!");
                    this.Hide();
                }
            }
        }
    }
}
