using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore
{
    public class StoredProcedures
    {
        public static string RetrieveProject = "selectProjectsofDeptLoc";
        public static string SelectAllEmployees = "getAllEmps";
        public static string InsertProject = "insertProject";
        public static string SelectDepartmentNum = "selectDepartmentNum";
        public static string SelectDepartmentLocation = "selectDepartmentLocation";
        //ASMAA
        public static string getusernames = "getusernames";
        public static string getusernameadmin = "getusernameadmin";
        public static string passwordofusername = "passwordofusername";
        public static string passwordofusernameadmin = "passwordofusernameadmin";
        public static string signupform = "signupform";
        public static string takenbooksforspecificuser = "takenbooksforspecificuser";
        public static string buyingbooksforspecificuser = "buyingbooksforspecificuser";
        public static string borrowingbooksforspecificuser = "borrowingbooksforspecificuser";
        public static string selectcountofbuyingbooks = "selectcountofbuyingbooks";
        public static string deletebook = "deletebook";
        public static string updatecountofbooks = "updatecountofbooks";
        public static string selectcountofborrowbooks = "selectcountofborrowbooks";
        public static string updatecountofborrowbooks = "updatecountofborrowbooks";
        public static string deleteborrowbook = "deleteborrowbook";
        public static string selectcountoftakebooks = "selectcountoftakebooks";
        public static string updatecountoftakebooks = "updatecountoftakebooks";
        public static string deletetakebook = "deletetakebook";
        public static string sellbooksofuser = "sellbooksofuser";
        public static string lendbooksofuser = "lendbooksofuser";
        public static string donatebooksofuser = "donatebooksofuser";
        public static string buyerbookformuser = "buyerbookformuser";
        public static string borrowbookformuser = "borrowbookformuser";
        public static string takerbookformuser = "takerbookformuser";
        public static string ISBNdonatebooksofuser = "ISBNdonatebooksofuser";
        public static string ISBNlendbooksofuser = "ISBNlendbooksofuser";
        public static string ISBNsellbooksofuser = "ISBNsellbooksofuser";
        public static string numofrowsofbuybooks = "numofrowsofbuybooks";
        public static string numofrowsofborrowbooks = "numofrowsofborrowbooks";
        public static string numofrowsoftakebooks = "numofrowsoftakebooks";
        public static string InsertBookToSell = "InsertBooksToSell";
        public static string InsertBookToLend = "InsertBooksToLend";
        public static string InsertBookToDonate = "InsertBooksToDonate";
        public static string InsertAuthor = "InsertAuthor";
        public static string InsertPublisher = "InsertPublicher";
        public static string deletebookfromtakefree = "deletebookfromtakefree";
        public static string deletebookfromborrow = "deletebookfromborrow";
        public static string deletebookfrombuy = "deletebookfrombuy";
        public static string isbndonate = "isbndonate";
        public static string isbnlend = "isbnlend";
        public static string isbnsell = "isbnsell";
        //DONIA
        public static string SellForm = "SelectToSELL";
        public static string FreeFrm = "SelectToDonate";
        public static string LendFrm = "SelectToLEND";
        public static string SellAll = "SellAll";
        public static string LendAll = "LendAll";
        public static string DonateAll = "DonateAll";
        public static string SelectAuthor = "SelectAuthor";
        public static string SelectPublisher = "SelectPublisher";
        public static string SelectAuthorDate = "SelectAuthorDate";
        public static string SelectPublisherAdresses = "SelectPublisherAdresses";
        public static string SelectPublisherPhone = "SelectPublisherPhone";
        
        
    }
}
