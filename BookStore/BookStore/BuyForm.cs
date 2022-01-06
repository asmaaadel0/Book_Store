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
    public partial class BuyForm : Form
    {
        private Form activeForm;
        private Button currentButton;
        Controller controllerObj;
        private string username;
        public BuyForm(string name)
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            username = name;
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectSell();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    currentButton = (Button)btnSender;

                }
            }
        }
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(childForm);
            this.panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }
        private void BuyForm_Load(object sender, EventArgs e)
        {
            LoadTheme();
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectSell();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //OpenChildForm(new BookDetails());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                BookDetails bookdetails = new BookDetails(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(), username);
                OpenChildForm(bookdetails);
            }
        }


    }
}
