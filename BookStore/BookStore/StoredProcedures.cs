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
    }
}
