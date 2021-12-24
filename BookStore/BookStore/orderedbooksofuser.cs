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
            DataTable dt = controllerObj.takenbooksforspecificuser(log.username());
            foreach (DataRow dr in dt.Rows)
                dataGridView1.Rows.Add(dr["title"].ToString());
            dt = controllerObj.buyingbooksforspecificuser(log.username());
            foreach (DataRow dr in dt.Rows)
                dataGridView3.Rows.Add(dr["title"].ToString());
            dt = controllerObj.borrowingbooksforspecificuser(log.username());
            foreach (DataRow dr in dt.Rows)
                dataGridView3.Rows.Add(dr["title"].ToString());
        }

        private void showbookstosell_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView3.Rows)
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
                    dataGridView3.Rows.Remove(row);
                }
            }
              
        }
    }
}
