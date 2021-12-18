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
