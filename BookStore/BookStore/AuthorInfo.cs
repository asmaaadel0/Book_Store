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
    public partial class AuthorInfo : Form
    {
        Controller controllerObj;
        public AuthorInfo(DataTable dt)
        {
            InitializeComponent();
            controllerObj = new Controller();
            string Name = "";
            if (dt != null)
            {
                if (dt.Rows[0][0] != null)
                {
                    Name = dt.Rows[0][0].ToString();
                    if (dt.Rows[0][1] != null)
                    {
                        Name += " ";
                        Name += dt.Rows[0][1].ToString();
                    }
                }

                if (dt.Rows[0][5] != null)
                {
                    if (dt.Rows[0][5].ToString() == "null")
                        Nationality.Text = "not Available";
                    else
                        Nationality.Text = dt.Rows[0][5].ToString();
                }
                else
                    Nationality.Text = "not Available";

                if (dt.Rows[0][4] != null)
                {
                    if (dt.Rows[0][4].ToString() == "null")
                        CityOfBirth.Text = "not Available";
                    else
                        CityOfBirth.Text = dt.Rows[0][4].ToString();
                }
                else
                    CityOfBirth.Text = "not Available";

                if (dt.Rows[0][6] != null)
                {
                    if (dt.Rows[0][6].ToString() == "null")
                        Information.Text = "not Available";
                    else
                        Information.Text = dt.Rows[0][6].ToString();
                    
                }
                else
                    Information.Text = "not Available";

             int x=0;
             bool b=Int32.TryParse(dt.Rows[0][2].ToString(), out x);
             DataTable dt2 = controllerObj.AuthorDate(x);
             if (dt2.Rows[0][0] != null)
             {
                 if (dt2.Rows[0][0].ToString() == "null")
                     DateOfBirth.Text = "not Available";
                 else
                     DateOfBirth.Text = dt2.Rows[0][0].ToString();
             }
             else
                 DateOfBirth.Text = "not Available";
            }
            AuthorName.Text = Name;
            if (AuthorName.Text == "")
                AuthorName.Text = "not Available";
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
