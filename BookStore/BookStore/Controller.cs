using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace BookStore
{
    public class Controller
    {
        DBManager dbMan;

        public Controller()
        {
            dbMan = new DBManager();
        }
        public int signupform(string fname, string lname, string username, string password, string email, string state, string city, string district, string street, int housnumber, string postalnum, string countrycode, string phonenumber)
        {
            string query = "insert into Users (Fname,Lname,username,PW,email,stat,city,district,street,HouseNumber,postalNumber,countrycode,PhoneNumber)" +
                            "values('" + fname + "','" + lname + "','" + username + "','" + password+ "','" + email + "','" + state + "','" + city + "','" + district + "','" + street + "'," + housnumber + ",'" + postalnum + "','" + countrycode +"','"+ phonenumber + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable usernames()
        {
            string query = "select username from Users;";
                return dbMan.ExecuteReader(query);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }

      
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        public DataTable SelectAllEmp()
        {

            string StoredProcedureName = StoredProcedures.SelectAllEmployees;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }


        public int InsertProject(string Pname, int pnumber, string Plocation, int Dnum)
        {

            string StoredProcedureName = StoredProcedures.InsertProject;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Pname", Pname);
            Parameters.Add("@Pnumber", pnumber);
            Parameters.Add("@Plocation", Plocation);
            Parameters.Add("@Dnum", Dnum);
            return dbMan.ExecuteNonQuery(StoredProcedureName,Parameters);
        }

        public DataTable SelectDepNum()
        {
            string StoredProcedureName = StoredProcedures.SelectDepartmentNum;
            return dbMan.ExecuteReader(StoredProcedureName, null);

        }
        public DataTable SelectDepLoc()
        {
            String StoredProcedureName = StoredProcedures.SelectDepartmentLocation;
            return dbMan.ExecuteReader(StoredProcedureName, null);

        }

        public DataTable SelectProject(string location)
        {
            String StoredProcedureName = StoredProcedures.RetrieveProject;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@location", location);
           return dbMan.ExecuteReader(StoredProcedureName,Parameters);
        }
    }
}
*/