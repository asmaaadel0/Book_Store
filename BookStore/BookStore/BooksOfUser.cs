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
        string username;
        public BooksOfUser(string name)
        {
            username = name;
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
                if (row.Cells[0].Value==null)
                    return;
                dataGridView1.Rows[j].Cells[1].Value = controllerObj.buyerbookformuser(username, controllerObj.ISBNsellbooksofuser(username, row.Cells[0].Value.ToString()));
                if (dataGridView1.Rows[j].Cells[1].Value != null)
                    dataGridView1.Rows[j].Cells["ordered"].Value = true;
                j++;
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
            {
                if (row.Cells[0].Value == null)
                    return;
                dataGridView3.Rows[j].Cells["taker"].Value = controllerObj.buyerbookformuser(username, controllerObj.ISBNsellbooksofuser(username, row.Cells[0].Value.ToString()));
                if (dataGridView3.Rows[j].Cells["taker"].Value != null)
                    dataGridView3.Rows[j].Cells["ordered"].Value = true;
                j++;
            }

        }

        private void showbookstolend_Click(object sender, EventArgs e)
        {
            int j = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells[0].Value == null)
                    return;
                dataGridView2.Rows[j].Cells["borrower"].Value = controllerObj.buyerbookformuser(username, controllerObj.ISBNsellbooksofuser(username, row.Cells[0].Value.ToString()));
                if (dataGridView2.Rows[j].Cells["borrower"].Value != null)
                    dataGridView2.Rows[j].Cells["ordered"].Value = true;
                j++;
            }
        }

        private void BooksOfUser_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Books to sell";
            dataGridView1.Columns[1].Name = "buyer";
            dataGridView1.Columns[2].Name = "ordered";
            int j = 0;
            int x = 0;
            DataTable dt = controllerObj.sellbooksofuser(username);
            DataTable dt2 = controllerObj.donatebooksofuser(username);
            DataTable dt3 = controllerObj.lendbooksofuser(username);
            if(dt==null&&dt2==null&&dt3==null)
            {
                MessageBox.Show("you haven't any books to show");
                return;
            }
            if(dt==null)
            {
                MessageBox.Show("you haven't books to sell");
            }
            if(dt!=null)
            {
                x = dt.Rows.Count;
                for (int i = 1; i <= x; i++)
                {
                    string[] row = new string[] { i.ToString() };
                    dataGridView1.Rows.Add(row);
                }
                foreach (DataRow dr in dt.Rows)
                {
                    dataGridView1.Rows[j].Cells["Books to sell"].Value = dr[0].ToString();
                    j++;
                }
            }
            dataGridView3.ColumnCount = 3;
            dataGridView3.Columns[0].Name = "Books to Donate";
            dataGridView3.Columns[1].Name = "taker";
            dataGridView3.Columns[2].Name = "ordered";
            j = 0;
            if (dt2 == null)
            {
                MessageBox.Show("you haven't books to sell");
            }
            if(dt2!=null)
            {
                x = dt2.Rows.Count;
                for (int i = 1; i <= x; i++)
                {
                    string[] row = new string[] { i.ToString() };
                    dataGridView3.Rows.Add(row);
                }
                foreach (DataRow dr in dt2.Rows)
                {
                    dataGridView3.Rows[j].Cells["Books to Donate"].Value = dr[0].ToString();
                    j++;
                }
            }
            dataGridView2.ColumnCount = 3;
            dataGridView2.Columns[0].Name = "Books to Lend";
            dataGridView2.Columns[1].Name = "borrower";
            dataGridView2.Columns[2].Name = "ordered";
            j = 0;
            if (dt3 == null)
            {
                MessageBox.Show("you haven't books to sell");
            }
            if(dt3!=null)
            {
                x = dt3.Rows.Count;
                for (int i = 1; i <= x; i++)
                {
                    string[] row = new string[] { i.ToString() };
                    dataGridView2.Rows.Add(row);
                }
                foreach (DataRow dr in dt3.Rows)
                {
                    dataGridView2.Rows[j].Cells["Books to lend"].Value = dr[0].ToString();
                    j++;
                }
            }
        }
    }
}
