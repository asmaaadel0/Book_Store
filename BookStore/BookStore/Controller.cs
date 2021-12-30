
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
            string StoredProcedureName = StoredProcedures.signupform;
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
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int selectcountofborrowbooks(string username)
        {
            string StoredProcedureName = StoredProcedures.selectcountofborrowbooks;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int selectcountoftakebooks(string username)
        {
            string StoredProcedureName = StoredProcedures.selectcountoftakebooks;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int deletebook(string username)
        {
            string StoredProcedureName = StoredProcedures.deletebook;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int deleteborrowbook(string username)
        {
            string StoredProcedureName = StoredProcedures.deleteborrowbook;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int deletetakebook(string username)
        {
            string StoredProcedureName = StoredProcedures.deletetakebook;
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
        public int updatecountofborrowbooks(string username, int count)
        {
            string StoredProcedureName = StoredProcedures.updatecountofborrowbooks;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@newcount", count);
            Parameters.Add("@username", username);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int updatecountoftakebooks(string username, int count)
        {
            string StoredProcedureName = StoredProcedures.updatecountoftakebooks;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@newcount", count);
            Parameters.Add("@username", username);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int InsertBookToSell(string isbn, string title, string category, System.Drawing.Image bookcover,int bookcount,int numofpages,string lang,int editionnum,string information,string publishingD,string username,int price)
        {

            string StoredProcedureName = StoredProcedures.InsertBookToSell;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ISBN", isbn);
            Parameters.Add("@title", title);
            Parameters.Add("@category", category);
            Parameters.Add("@coverphoto",bookcover);
            Parameters.Add("@Bookcount", bookcount);
            Parameters.Add("@numOfPages",numofpages);
            Parameters.Add("@lang",lang);
            Parameters.Add("@editionNum",editionnum);
            Parameters.Add("@information",information);
            Parameters.Add("@PublishingDate",publishingD);
            Parameters.Add("@Username",username);
            Parameters.Add("@price",price);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertBookToDonate(string isbn, string title, string category, System.Drawing.Image bookcover, int bookcount, int numofpages, string lang, int editionnum, string information, string publishingD, string username)
        {

            string StoredProcedureName = StoredProcedures.InsertBookToDonate;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ISBN", isbn);
            Parameters.Add("@title", title);
            Parameters.Add("@category", category);
            Parameters.Add("@coverphoto", bookcover);
            Parameters.Add("@Bookcount", bookcount);
            Parameters.Add("@numOfPages", numofpages);
            Parameters.Add("@lang", lang);
            Parameters.Add("@editionNum", editionnum);
            Parameters.Add("@information", information);
            Parameters.Add("@PublishingDate", publishingD);
            Parameters.Add("@Username", username);
            

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int InsertBookToLend(string isbn, string title, string category, System.Drawing.Image bookcover, int bookcount, int numofpages, string lang, int editionnum, string information, string publishingD, string username, int period)
        {

            string StoredProcedureName = StoredProcedures.InsertBookToLend;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ISBN", isbn);
            Parameters.Add("@title", title);
            Parameters.Add("@category", category);
            Parameters.Add("@coverphoto", bookcover);
            Parameters.Add("@Bookcount", bookcount);
            Parameters.Add("@numOfPages", numofpages);
            Parameters.Add("@lang", lang);
            Parameters.Add("@editionNum", editionnum);
            Parameters.Add("@information", information);
            Parameters.Add("@PublishingDate", publishingD);
            Parameters.Add("@Username", username);
            Parameters.Add("@period", period);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int InsertAuthor(string Fname,string Lname,int Author_ID,string DateOfBirth,string CityOfBirth,string Nationality,string A_Information)
        {
            string storedProcedurename = StoredProcedures.InsertAuthor;
            Dictionary<string, object> Parameters=new Dictionary<string,object>();
            Parameters.Add("@Fname",Fname);
            Parameters.Add("@Lname",Lname);
            Parameters.Add("@Author_ID",Author_ID);
            Parameters.Add("@DateOfBirth",DateOfBirth);
            Parameters.Add("@CityOfBirth", CityOfBirth);
            Parameters.Add("@Nationality", Nationality);
            Parameters.Add("@A_Information", A_Information);
            return dbMan.ExecuteNonQuery(storedProcedurename, Parameters);
        }
        public int InsertPublisher(int Publisher_ID, string Publisher_name, string Email, string P_Information, string Fax, System.Drawing.Image Logo)
        {
            string storedProcedurename = StoredProcedures.InsertPublisher;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Publisher_ID", Publisher_ID);
            Parameters.Add("@Publisher_name", Publisher_name);
            Parameters.Add("@Email", Email);
            Parameters.Add("@P_Information", P_Information);
            Parameters.Add("@Fax", Fax);
            Parameters.Add("@Logo", Logo);
            return dbMan.ExecuteNonQuery(storedProcedurename, Parameters);
        }



        public DataTable sellbooksofuser(string username)
        {
            string StoredProcedureName = StoredProcedures.sellbooksofuser;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable lendbooksofuser(string username)
        {
            string StoredProcedureName = StoredProcedures.lendbooksofuser;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable donatebooksofuser(string username)
        {
            string StoredProcedureName = StoredProcedures.donatebooksofuser;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public string buyerbookformuser(string username,string ISBN)
        {
            string StoredProcedureName = StoredProcedures.buyerbookformuser;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            Parameters.Add("@ISBN", ISBN);
            return (string)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public DataTable borrowbookformuser(string username,string ISBN)
        {
            string StoredProcedureName = StoredProcedures.borrowbookformuser;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            Parameters.Add("@ISBN", ISBN);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable takerbookformuser(string username,string ISBN)
        {
            string StoredProcedureName = StoredProcedures.takerbookformuser;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            Parameters.Add("@ISBN", ISBN);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public string ISBNdonatebooksofuser(string username,string title)
        {
            string StoredProcedureName = StoredProcedures.ISBNdonatebooksofuser;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            Parameters.Add("@title", title);
            return (string)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public string ISBNlendbooksofuser(string username, string title)
        {
            string StoredProcedureName = StoredProcedures.ISBNlendbooksofuser;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            Parameters.Add("@title", title);
            return (string)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public string ISBNsellbooksofuser(string username, string title)
        {
            string StoredProcedureName = StoredProcedures.ISBNsellbooksofuser;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            Parameters.Add("@title", title);
            return (string)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public int numofrowsofbuybooks()
        {
            string StoredProcedureName = StoredProcedures.numofrowsofbuybooks;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public int numofrowsofborrowbooks()
        {
            string StoredProcedureName = StoredProcedures.numofrowsofborrowbooks;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public int numofrowsoftakebooks()
        {
            string StoredProcedureName = StoredProcedures.numofrowsoftakebooks;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);

        }
    }
}
