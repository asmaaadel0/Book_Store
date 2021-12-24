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
    public partial class BooksOfUser : Form
    {
        Controller controllerObj;
        login log = new login();
        public BooksOfUser()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            int j = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dataGridView1.Rows[j].Cells["buyer"].Value = controllerObj.buyerbookformuser(log.username(), controllerObj.ISBNsellbooksofuser(log.username(), row.Cells[0].Value.ToString()));
                if (dataGridView1.Rows[j].Cells["buyer"].Value == null)
                    dataGridView1.Rows[j].Cells["ordered"].Value =true;
            }
               

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void showbookstodonate_Click(object sender, EventArgs e)
        {
            int j = 0;
            foreach (DataGridViewRow row in dataGridView3.Rows)
                dataGridView3.Rows[j].Cells["taker"].Value = controllerObj.buyerbookformuser(log.username(), controllerObj.ISBNsellbooksofuser(log.username(), row.Cells[0].Value.ToString()));
            if (dataGridView3.Rows[j].Cells["taker"].Value == null)
                dataGridView3.Rows[j].Cells["ordered"].Value = true;
        }

        private void showbookstolend_Click(object sender, EventArgs e)
        {
            int j = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
                dataGridView2.Rows[j].Cells["borrower"].Value = controllerObj.buyerbookformuser(log.username(), controllerObj.ISBNsellbooksofuser(log.username(), row.Cells[0].Value.ToString()));
            if (dataGridView1.Rows[j].Cells["borrower"].Value == null)
                dataGridView1.Rows[j].Cells["ordered"].Value = true;
        }

        private void BooksOfUser_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Books to sell";
            dataGridView1.Columns[1].Name = "buyer";
            dataGridView1.Columns[2].Name = "ordered";
            for (int i = 1; i <= controllerObj.numofrowsofbuybooks(); i++)
            {
                string[] row = new string[] { i.ToString() };
                dataGridView1.Rows.Add(row);
            }
            int j = 0;
            DataTable dt = controllerObj.sellbooksofuser(log.username());
            foreach (DataRow dr in dt.Rows)
            {
                dataGridView1.Rows[j].Cells["Books to sell"].Value = dr[0].ToString();
                j++;
            }
            dataGridView3.ColumnCount = 3;
            dataGridView3.Columns[0].Name = "Books to Donate";
            dataGridView3.Columns[1].Name = "taker";
            dataGridView3.Columns[2].Name = "ordered";
            for (int i = 1; i <= controllerObj.numofrowsofbuybooks(); i++)
            {
                string[] row = new string[] { i.ToString() };
                dataGridView3.Rows.Add(row);
            }
            j = 0;
            dt = controllerObj.donatebooksofuser(log.username());
            foreach (DataRow dr in dt.Rows)
            {
                dataGridView1.Rows[j].Cells["Books to Donate"].Value = dr[0].ToString();
                j++;
            }
            dataGridView2.ColumnCount = 3;
            dataGridView2.Columns[0].Name = "Books to Lend";
            dataGridView2.Columns[1].Name = "borrower";
            dataGridView2.Columns[2].Name = "ordered";
            for (int i = 1; i <= controllerObj.numofrowsofbuybooks(); i++)
            {
                string[] row = new string[] { i.ToString() };
                dataGridView2.Rows.Add(row);
            }
            j = 0;
            dt = controllerObj.lendbooksofuser(log.username());
            foreach (DataRow dr in dt.Rows)
            {
                dataGridView2.Rows[j].Cells["Books to lend"].Value = dr[0].ToString();
                j++;
            }
        }
    }
}
