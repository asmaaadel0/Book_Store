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
    public partial class orderedbooksofuser : Form
    {
        Controller controllerObj;
        login log = new login();
        public orderedbooksofuser()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void done_Click(object sender, EventArgs e)
        {

        }

        private void orderedbooksofuser_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            dataGridView4.ColumnCount = 3;
            dataGridView4.Columns[0].Name = "Books to buy";
            dataGridView4.Columns[1].Name = "cancel";
            dataGridView4.Columns[2].Name = "Approve";
            for (int i = 1; i <= controllerObj.numofrowsofbuybooks(); i++)
            {
                string[] row = new string[] { i.ToString() };
                dataGridView4.Rows.Add(row);
            }
            int j = 0;
            DataTable dt = controllerObj.takenbooksforspecificuser(log.username());
            foreach (DataRow dr in dt.Rows)
            {
                dataGridView4.Rows[j].Cells["Books to buy"].Value = dr[0].ToString();
                j++;
            }
            dataGridView3.ColumnCount = 3;
            dataGridView3.Columns[0].Name = "Books to borrow";
            dataGridView3.Columns[1].Name = "cancel";
            dataGridView3.Columns[2].Name = "Approve";
            for (int i = 1; i <= controllerObj.numofrowsofbuybooks(); i++)
            {
                string[] row = new string[] { i.ToString() };
                dataGridView3.Rows.Add(row);
            }
            j = 0;
            dt = controllerObj.takenbooksforspecificuser(log.username());
            foreach (DataRow dr in dt.Rows)
            {
                dataGridView1.Rows[j].Cells["Books to borrow"].Value = dr[0].ToString();
                j++;
            }
            dataGridView2.ColumnCount = 3;
            dataGridView2.Columns[0].Name = "Books to Donate";
            dataGridView2.Columns[1].Name = "cancel";
            dataGridView2.Columns[2].Name = "Approve";
            for (int i = 1; i <= controllerObj.numofrowsofbuybooks(); i++)
            {
                string[] row = new string[] { i.ToString() };
                dataGridView2.Rows.Add(row);
            }
            j = 0;
            dt = controllerObj.takenbooksforspecificuser(log.username());
            foreach (DataRow dr in dt.Rows)
            {
                dataGridView2.Rows[j].Cells["Books to Donate"].Value = dr[0].ToString();
                j++;
            }
        }

        private void showbookstosell_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView4.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["approvecolumn"].Value);
                if (isSelected)
                {
                    if (controllerObj.selectcountofbuyingbooks(log.username()) == 1)
                        controllerObj.deletebook(log.username());
                    else
                    {
                        int newcount = controllerObj.selectcountofbuyingbooks(log.username()) - 1;
                        controllerObj.updatecountofbooks(log.username(), newcount);
                    }
                }
                isSelected = Convert.ToBoolean(row.Cells["cancelcolumn"].Value);
                if (isSelected)
                {
                    dataGridView4.Rows.Remove(row);
                }
            }

        }

        private void borrow_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["approvecolumn2"].Value);
                if (isSelected)
                {
                    if (controllerObj.selectcountofborrowbooks(log.username()) == 1)
                        controllerObj.deleteborrowbook(log.username());
                    else
                    {
                        int newcount = controllerObj.selectcountofborrowbooks(log.username()) - 1;
                        controllerObj.updatecountofborrowbooks(log.username(), newcount);
                    }
                }
                isSelected = Convert.ToBoolean(row.Cells["cancelcolumn2"].Value);
                if (isSelected)
                {
                    dataGridView3.Rows.Remove(row);
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void donate_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["approvecolumn3"].Value);
                if (isSelected)
                {
                    if (controllerObj.selectcountoftakebooks(log.username()) == 1)
                        controllerObj.deletetakebook(log.username());
                    else
                    {
                        int newcount = controllerObj.selectcountoftakebooks(log.username()) - 1;
                        controllerObj.updatecountoftakebooks(log.username(), newcount);
                    }
                }
                isSelected = Convert.ToBoolean(row.Cells["cancelcolumn3"].Value);
                if (isSelected)
                {
                    dataGridView2.Rows.Remove(row);
                }
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
