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
    public partial class publiherInfo : Form
    {
        Controller controllerObj;
        public publiherInfo(DataTable dt)
        {
            controllerObj = new Controller();
            InitializeComponent();
            int x = 0;
            bool b = Int32.TryParse(dt.Rows[0][0].ToString(), out x);
            DataTable Adresses = controllerObj.PublisherAdress(x);
            DataTable tableAdress = new DataTable();
            tableAdress.Columns.Add("Available Adresses", typeof(string));
            string CompleteAdress = "";
            foreach (DataRow row in Adresses.Rows)
            {
                if (row[5].ToString()!="null")
                    CompleteAdress = row[5].ToString()+"-";
                if (row[4].ToString() != "null")
                    CompleteAdress = row[4].ToString() + "-";
                if (row[3].ToString() != "null")
                    CompleteAdress = row[3].ToString() + "-";
                if (row[2].ToString() != "null")
                    CompleteAdress = row[2].ToString() + "-";
                if (row[1].ToString() != "null")
                    CompleteAdress = row[1].ToString();
                tableAdress.Rows.Add(CompleteAdress);  
            }
            dataGridView1.DataSource = tableAdress;

            int y = 0;
            bool b2 = Int32.TryParse(dt.Rows[0][0].ToString(), out y);
            DataTable Phone = controllerObj.PublisherPhone(y);
            DataTable tablePhone = new DataTable();
            tablePhone.Columns.Add("PhoneNumbers", typeof(string));
            string CompletePhoneNumber = "";
            foreach (DataRow row in Phone.Rows)
            {
                if (row[1].ToString() != "null")
                    CompletePhoneNumber = row[1].ToString() + "-";
                if (row[2].ToString() != "null")
                    CompletePhoneNumber = row[2].ToString() + "-";
                tablePhone.Rows.Add(CompletePhoneNumber);
            }
            dataGridView2.DataSource = tablePhone;
            if (dt != null)
            {
                if (dt.Rows[0][1] != null)
                {
                    if (dt.Rows[0][1].ToString() == "null")
                        PublisherName.Text = "not Available";
                    else
                        PublisherName.Text = dt.Rows[0][1].ToString();
                }
                else
                    PublisherName.Text = "not Available";

                if (dt.Rows[0][4] != null)
                {
                    if (dt.Rows[0][4].ToString() == "null")
                        FaxtextBox.Text = "not Available";
                    else
                        FaxtextBox.Text = dt.Rows[0][4].ToString();
                }
                else
                    FaxtextBox.Text = "not Available";

                if (dt.Rows[0][2] != null)
                {
                    if (dt.Rows[0][2].ToString() == "null")
                        EmailPublisher.Text = "not Available";
                    else
                        EmailPublisher.Text = dt.Rows[0][2].ToString();
                }
                else
                    EmailPublisher.Text = "not Available";

                if (dt.Rows[0][3] != null)
                {
                    if (dt.Rows[0][3].ToString() == "null")
                        Information.Text = "not Available";
                    else
                        Information.Text = dt.Rows[0][3].ToString();
                }
                else
                    Information.Text = "not Available";


            }
        }
        private void FaxtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void publiherInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
