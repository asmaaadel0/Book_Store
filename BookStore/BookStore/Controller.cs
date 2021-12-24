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
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
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
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable usernames()
        {
            string StoredProcedureName = StoredProcedures.getusernames;
            return dbMan.ExecuteReader(StoredProcedureName,null);
        }
        public DataTable usernameadmin()
        {
            string StoredProcedureName = StoredProcedures.getusernameadmin;
            return dbMan.ExecuteReader(StoredProcedureName, null); 
        }
        public string passwordofusername(string username)
        {
            string StoredProcedureName = StoredProcedures.passwordofusername;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            return (string)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public string passwordofusernameadmin(string username)
        {
            string StoredProcedureName = StoredProcedures.passwordofusernameadmin;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            return (string)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public int signupform(string fname, string lname, string username, string password, string email, string state, string city, string district, string street, string housnumber, string postalnum, string countrycode, string phonenumber)
        {
            string StoredProcedureName = StoredProcedures.InsertProject;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Fname", fname);
            Parameters.Add("@Lname", lname);
            Parameters.Add("@username", username);
            Parameters.Add("@PW", password);
            Parameters.Add("@email", email);
            Parameters.Add("@stat", state);
            Parameters.Add("@city", city);
            Parameters.Add("@district", district);
            Parameters.Add("@street", district);
            Parameters.Add("@HouseNumber", housnumber);
            Parameters.Add("@postalNumber", postalnum);
            Parameters.Add("@countrycode", countrycode);
            Parameters.Add("@PhoneNumber", phonenumber);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable takenbooksforspecificuser(string username)
        {
            string StoredProcedureName = StoredProcedures.takenbooksforspecificuser;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable buyingbooksforspecificuser(string username)
        {
            string StoredProcedureName = StoredProcedures.buyingbooksforspecificuser;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable borrowingbooksforspecificuser(string username)
        {
            string StoredProcedureName = StoredProcedures.borrowingbooksforspecificuser;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public int selectcountofbuyingbooks(string username)
        {
            string StoredProcedureName = StoredProcedures.selectcountofbuyingbooks;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public int deletebook(string username)
        {
            string StoredProcedureName = StoredProcedures.deletebook;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int updatecountofbooks(string username,int count)
        {
            string StoredProcedureName = StoredProcedures.updatecountofbooks;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@newcount", count);
            Parameters.Add("@username", username);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
    }
}
